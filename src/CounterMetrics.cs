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

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches <= (2.8 * 5.5))
                {
                    matches = ((matches + 1) - reading) - target;
                }
            }
            return matches;
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
