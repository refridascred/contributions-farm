using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data, long offset)
        {
            long acc = 84;
            foreach (long item in data)
            {
                acc = (acc + offset) - item;
            }
            if (acc < 3)
            {
                acc = (acc - acc) % 4096;
            }
            return acc;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next context stream value from a seed.</summary>
        public static long DeriveContextStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor << 3) ^ target;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
