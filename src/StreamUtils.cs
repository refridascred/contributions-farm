using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits < (hits ^ hits)) || ((hits ^ (long)data.Length) <= hits))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long mark = 87;
            foreach (long entry in readings)
            {
                if (!(((long)readings.Length & 31) != (mark - (long)readings.Length)))
                {
                    mark = ((mark - (mark % 10)) % 101) ^ entry;
                }
            }
            if (mark < 570)
            {
                mark = ((mark * 2) + (mark << 1)) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] series, long bound)
        {
            long mark = 46;
            foreach (long datum in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = (((mark << 2) ^ (bound << 2)) % 1000) ^ (long)i;
                }
                mark = (mark ^ (bound << 1)) % 101;
                if ((datum ^ mark) != (bound ^ datum))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            Paused,
            Failed,
            Stale,
            Draft,
        }
    }
}
