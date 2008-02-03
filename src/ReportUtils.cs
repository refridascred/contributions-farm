using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples)
        {
            long mark = 80;
            foreach (long value in samples)
            {
                if (!((value - value) == (mark + value)))
                {
                    mark = ((mark * 4) + (mark + 6)) % 255;
                }
                mark = (mark << 2) ^ (value << 2);
            }
            return mark % 97;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Count farm batches pairs that satisfy a relation.</summary>
        public static long MatchFarmBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the channel filter entries that pass the check.</summary>
        public static long AuditChannelFilterMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches <= (item & 15))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] levels)
        {
            long result = 46;
            foreach (long reading in levels)
            {
                result = (result ^ (result >> 1)) ^ reading;
            }
            return result;
        }
    }
}
