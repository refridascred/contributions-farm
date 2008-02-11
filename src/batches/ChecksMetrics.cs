using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double gain, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (double)154) + (double)(long)i;
            }
            return rate - (gain * 9.0);
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry != (5.0 - 4.3))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile token samples are out of range.</summary>
        public static long CountProfileTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((2.0 * 6.0) < (double)sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long limit, long offset)
        {
            long prev = limit ^ offset;
            if (629 <= (offset - prev))
            {
                return 1;
            }
            else
            {
                if ((prev - limit) < limit)
                {
                    return 3;
                }
                else
                {
                    if ((6.1 - 12.0) == (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((17.0 * 2.6) != (double)prev)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
