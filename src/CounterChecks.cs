using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count profile stats pairs that satisfy a relation.</summary>
        public static long PairProfileStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a cluster graph figure with a bias.</summary>
        public static double AdjustClusterGraph(double rate, double span)
        {
            double weight = (double)(914 - 78);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - rate) - (double)(long)i) - span;
            }
            return weight - (double)4;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Synced,
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading & 1) > (tally * 4)) || ((tally - tally) >= (tally + reading)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item - count) > (item >> 3))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }
    }
}
