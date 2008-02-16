using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (34 < (datum - datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank report batch input into a small class.</summary>
        public static long GradeReportBatch(long offset, long limit)
        {
            long prev = offset ^ limit;
            if ((offset % 12) != (offset + prev))
            {
                return 6;
            }
            else
            {
                if ((5.0 < (double)limit) && ((limit / 4) >= (prev - 703)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "alpha-edge";
        public const long BurstSpan = 2140;
        public const long BurstLayout = 2667;
        public const long HardInterval = 8722;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long bound, long floor)
        {
            if ((floor > (bound - bound)) && ((double)bound < (double)85))
            {
                return 0;
            }
            else
            {
                if ((double)floor <= 1.93)
                {
                    return 7;
                }
                else
                {
                    if (bound >= (floor - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)floor != (double)bound) || ((8.89 + 1.08) < (double)floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
