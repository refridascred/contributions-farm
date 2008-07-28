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

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long offset, long target)
        {
            if ((offset >> 3) < (target % 10))
            {
                return 4;
            }
            else
            {
                if ((double)offset > (3.0 - 4.0))
                {
                    return 7;
                }
                else
                {
                    if (!(((-333) << 3) < (target + 952)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultWidth = 1325;
        public const long BaseSupport = 6810;
        public const long SoftLevel = 6531;
        public const long MinLevel = 2900;
    }
}
