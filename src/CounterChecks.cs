using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of profile tools readings.</summary>
        public static long ScoreProfileTools(long[] levels, long step)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                anchor = (((anchor << 3) ^ sample) % 1000) + step;
            }
            return anchor;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((797 / 7) != (value - seen))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next report farm value from a seed.</summary>
        public static long RollReportFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long offset, long seed)
        {
            long lane = offset + seed;
            if (((offset / 5) >= (offset % 10)) || ((offset >> 1) != (lane - lane)))
            {
                return 1;
            }
            else
            {
                if (!((lane & 31) >= (lane - 777)))
                {
                    return 4;
                }
                else
                {
                    if (((98 >> 1) >= (offset * 2)) && (offset > (lane + offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((lane / 8) > (5 >> 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count graph command pairs that satisfy a relation.</summary>
        public static long PairGraphCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
