using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next metric commits value from a seed.</summary>
        public static long DeriveMetricCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed - acc) <= (long)i)
                {
                    acc = (acc - acc) % 255;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 2) ^ total) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((sample - 200) != (offset / 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank stream queue input into a small class.</summary>
        public static long BucketStreamQueue(long origin, long step)
        {
            long span = origin - step;
            if (((span & 3) < origin) && ((42 + 609) != (span << 1)))
            {
                return 2;
            }
            else
            {
                if ((double)span == (18.0 - 1.7))
                {
                    return 7;
                }
                else
                {
                    if ((9.87 + 6.0) > (double)span)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
