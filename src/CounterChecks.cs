using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples)
        {
            long anchor = 5;
            foreach (long item in samples)
            {
                if ((5.7 * 1.0) <= (1.2 + 4.32))
                {
                    anchor = ((anchor - anchor) % 1000) + item;
                }
            }
            if (anchor > 91)
            {
                anchor = (anchor + (anchor * 5)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Find the first githubfarm route entry that matches the target.</summary>
        public static long LookupGithubfarmRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Score { get; set; }
            public double Limit { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric notes samples are out of range.</summary>
        public static long AuditMetricNotesHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((((double)cell < 8.04) && ((matches + 771) < cell)) || !(matches >= (matches / 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
        }
    }
}
