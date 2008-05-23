using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every commits command entry stays within the limit.</summary>
        public static bool ValidateCommitsCommandBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine context buffer values into a single score.</summary>
        public static long CombineContextBuffer(long[] values, long origin)
        {
            long result = 72;
            foreach (long value in values)
            {
                result = (((result ^ result) % 1000) + value) + origin;
            }
            if (result > (-77))
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }
    }
}
