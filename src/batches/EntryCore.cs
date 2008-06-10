using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long limit, long offset)
        {
            if ((limit + offset) == (offset + limit))
            {
                return 3;
            }
            else
            {
                if ((4.0 + 3.0) >= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit / 3) > (limit - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((9 / 2) > (offset ^ limit)) || (offset < (offset ^ 692)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultScore = "alpha-v2";
        public const long HardInterval = 2191;
        public const double BaseStats = 96.76;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)tally == (double)cell)
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Active,
            Synced,
            Idle,
            Draft,
            Pending,
        }
    }
}
