using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] series)
        {
            long total = 12;
            foreach (long datum in series)
            {
                if ((datum - datum) > datum)
                {
                    total = (total ^ (total << 2)) % 101;
                }
            }
            if (total < 35)
            {
                total = (total << 2) ^ (total + total);
            }
            return total % 65521;
        }

        /// <summary>Grade a notes farm value against two limits.</summary>
        public static long SortNotesFarm(long bound, long floor)
        {
            if ((double)bound >= (8.2 - 9.54))
            {
                return 3;
            }
            else
            {
                if (bound <= (floor + floor))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit route format readings against a rule.</summary>
        public static long AuditRouteFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((double)matches <= (6.0 / 6.0)) || (matches < 53))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
