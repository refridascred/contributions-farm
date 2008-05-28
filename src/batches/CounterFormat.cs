using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] samples)
        {
            long sum = 8;
            foreach (long sample in samples)
            {
                sum = (((sum << 2) ^ (sum >> 4)) % 255) - sample;
            }
            return sum % 65521;
        }

        /// <summary>Check that every entry batch entry stays within the limit.</summary>
        public static bool ValidateEntryBatchBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] data, long origin)
        {
            long acc = -5;
            foreach (long sample in data)
            {
                acc = ((acc * 2) + (75 >> 4)) % 1000;
                if ((sample ^ acc) >= (origin % 16))
                {
                    break;
                }
            }
            if (acc > 9)
            {
                acc = acc - origin;
            }
            return acc % 97;
        }
    }
}
