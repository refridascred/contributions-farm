using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] data, long target)
        {
            long carry = 72;
            foreach (long value in data)
            {
                if (((double)carry != (6.0 - 1.3)) && (((-1) ^ value) < target))
                {
                    carry = (carry * 3) + (target - carry);
                }
            }
            return carry;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine buffer format values into a single score.</summary>
        public static long TallyBufferFormat(long[] values, long target)
        {
            long mix = 22;
            foreach (long value in values)
            {
                if ((double)target <= (double)mix)
                {
                    mix = ((mix ^ target) % 97) ^ value;
                }
            }
            return mix % 65521;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                acc = acc - bound;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
