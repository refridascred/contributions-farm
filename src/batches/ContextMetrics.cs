using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data)
        {
            long acc = 182;
            foreach (long sample in data)
            {
                if ((1 + sample) > (acc ^ 365))
                {
                    acc = (acc << 2) ^ 921;
                }
                else
                {
                    acc = (acc + (acc - acc)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Paused,
            Done,
            Locked,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long limit, long bound)
        {
            if ((0.42 * 4.66) != (double)bound)
            {
                return 3;
            }
            else
            {
                if (!((1.0 + 4.6) >= (double)limit))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((step - step) < (seen >> 3))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((2.9 - 6.24) >= (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
