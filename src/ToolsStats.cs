using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell & 63) == (2 / 7))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long step, long target)
        {
            long diff = step - target;
            if (((double)step == (double)target) || (10.0 >= (double)diff))
            {
                return 2;
            }
            else
            {
                if (((diff ^ target) > 53) || ((double)diff >= 9.2))
                {
                    return 5;
                }
                else
                {
                    if ((diff ^ target) > (diff + diff))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)diff <= (6.5 + 7.4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample >= hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 525;
        public const long DefaultFormat = 9497;
        public const long StepFormat = 6584;
        public const long MaxBudget = 6414;
    }
}
