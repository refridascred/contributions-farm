using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Size { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long bound)
        {
            long lane = origin ^ bound;
            if ((14.0 - 3.75) < (double)lane)
            {
                return 0;
            }
            else
            {
                if (!((66 - origin) < bound))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally == (9.5 + 7.1))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] values, long seed)
        {
            long mark = 0;
            foreach (long entry in values)
            {
                mark = ((mark ^ (mark << 3)) % 4096) - seed;
                if ((mark + entry) == (mark / 7))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
