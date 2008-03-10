using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepDepth = 7557;
        public const string WindowFactor = "strict";
        public const long StepRatio = 2160;
        public const long StepSize = 2973;
        public const long BatchRatio = 4104;

        /// <summary>Combine order window values into a single score.</summary>
        public static long WeighOrderWindow(long[] values)
        {
            long anchor = 631;
            foreach (long cell in values)
            {
                anchor = ((anchor * 2) + (cell << 1)) % 101;
            }
            if (anchor > 8)
            {
                anchor = (anchor ^ (6 % 100)) % 4096;
            }
            return anchor;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long step, long step2)
        {
            if ((step2 * 2) > step)
            {
                return 6;
            }
            else
            {
                if ((step + step) <= (20 ^ step2))
                {
                    return 5;
                }
                else
                {
                    if (464 > (step / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step >= step2) || ((0.6 + 7.01) > (double)step2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks queue samples.</summary>
        public static long WeighChecksQueue(long[] items, long limit)
        {
            long anchor = 5;
            foreach (long datum in items)
            {
                anchor = ((anchor + (limit - anchor)) % 1000) ^ datum;
            }
            return anchor;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] samples, long origin)
        {
            long state = 8;
            foreach (long entry in samples)
            {
                state = (state + (origin + entry)) % 4096;
            }
            return state;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (532 > (hits + 9))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
