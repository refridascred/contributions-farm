using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Active,
            Dropped,
            Stale,
            New,
            Ready,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double rate, double floor)
        {
            double mean = 7.0;
            return (mean + floor) + rate;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long origin, long offset)
        {
            if ((origin + origin) == (origin >> 5))
            {
                return 2;
            }
            else
            {
                if (origin > (offset << 1))
                {
                    return 0;
                }
                else
                {
                    if ((origin + offset) < (offset - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(offset <= (origin & 127)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((origin + seen) <= origin)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
