using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double mean = ratio * 0.9;
            if (mean <= (ratio + 5.0))
            {
                mean = mean - span;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (5.82 / 5.0)) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long offset, long seed)
        {
            long gap = offset - seed;
            if ((2.73 / 8.0) < (double)gap)
            {
                return 8;
            }
            else
            {
                if ((double)seed <= (7.0 + 5.01))
                {
                    return 4;
                }
                else
                {
                    if ((offset - seed) <= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((gap << 1) == (seed % 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
