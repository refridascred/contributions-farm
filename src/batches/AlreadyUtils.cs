using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of buffer commits readings.</summary>
        public static long TotalBufferCommits(long[] samples)
        {
            long result = 2;
            foreach (long entry in samples)
            {
                if (entry >= (entry << 3))
                {
                    result = result - (166 - result);
                }
                if (!(((-74) >> 2) < (entry / 8)))
                {
                    result = (result ^ 4) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (result % 97)) % 101;
                }
                if ((entry >> 4) <= (entry - 7))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long seed)
        {
            if ((9.3 - 6.8) <= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((seed & 63) > seed)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed <= (3.0 + 9.6))
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

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
