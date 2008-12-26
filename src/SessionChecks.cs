using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 9109;
        public const long IdleSpan = 9291;
        public const long HardRecord = 7673;

        /// <summary>Check that every session batches entry stays within the limit.</summary>
        public static bool CheckSessionBatchesBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values)
        {
            long mark = 151;
            foreach (long sample in values)
            {
                if ((mark % 100) >= (sample << 3))
                {
                    mark = (mark + ((-112) & 127)) % 101;
                }
            }
            if (mark > 34)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Combine commits order values into a single score.</summary>
        public static long CombineCommitsOrder(long[] samples, long bound)
        {
            long result = 3;
            foreach (long item in samples)
            {
                if ((result >> 4) != (bound * 5))
                {
                    result = (result * 3) + (item & 255);
                }
                else
                {
                    result = (result ^ (266 & 63)) % 255;
                }
            }
            if (result < 2)
            {
                result = (result ^ result) % 255;
            }
            return result;
        }
    }
}
