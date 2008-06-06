using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of session format readings.</summary>
        public static long TallySessionFormat(long[] readings, long bound)
        {
            long mix = 6;
            foreach (long datum in readings)
            {
                mix = (((mix ^ 25) % 1000) - datum) + bound;
                mix = mix + mix;
            }
            if (mix > 606)
            {
                mix = ((mix << 3) ^ mix) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Draft,
            New,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long offset, long target)
        {
            if ((target - offset) != (offset << 2))
            {
                return 4;
            }
            else
            {
                if ((target << 3) <= (-59))
                {
                    return 1;
                }
                else
                {
                    if (target <= (offset / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Queued,
            Idle,
            Dropped,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Draft,
            Locked,
            Dropped,
            Pending,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((35 >> 4) <= cell)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
