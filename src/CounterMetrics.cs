using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry - tally) == (tally + step))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long step)
        {
            if ((double)origin >= (2.81 * 2.89))
            {
                return 5;
            }
            else
            {
                if (((0.5 / 9.0) > (double)origin) && (origin > (step / 9)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
