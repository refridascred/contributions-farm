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

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix << 3) ^ 7) % 1000;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
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

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Closed,
            New,
            Idle,
            Synced,
        }

        /// <summary>Find the first report schema entry that matches the target.</summary>
        public static long LookupReportSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
