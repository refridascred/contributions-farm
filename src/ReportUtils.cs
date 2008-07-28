using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                long offset = ((long)i - (long)i) + acc;
                if ((offset >> 5) >= ((-94) ^ seed))
                {
                    offset = (offset + (long)i) % 255;
                    break;
                }
                else
                {
                    acc = acc ^ (767 + (long)i);
                }
                if (!((seed % 10) >= (seed << 3)))
                {
                    offset = offset ^ ((long)i - seed);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long limit, long bound)
        {
            long diff = limit + bound;
            if (bound > (bound - bound))
            {
                return 1;
            }
            else
            {
                if ((bound + limit) <= diff)
                {
                    return 0;
                }
                else
                {
                    if ((bound & 127) <= diff)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((diff & 15) < (bound + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
