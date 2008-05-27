using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long offset, long target)
        {
            if ((offset >> 1) < offset)
            {
                return 6;
            }
            else
            {
                if ((target * 5) > 34)
                {
                    return 2;
                }
                else
                {
                    if ((offset + 997) > (target >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target ^ offset) < target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((target - sample) <= sample)
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

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits payload readings.</summary>
        public static long FoldCommitsPayload(long[] values)
        {
            long mix = 54;
            foreach (long datum in values)
            {
                if ((double)mix > (9.8 + 2.6))
                {
                    mix = ((mix << 3) ^ (long)values.Length) + datum;
                }
            }
            return mix;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Paused,
            Draft,
            Idle,
            Queued,
        }
    }
}
