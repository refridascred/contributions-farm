using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate route token samples.</summary>
        public static long ScoreRouteToken(long[] items, long limit)
        {
            long state = -8;
            foreach (long cell in items)
            {
                state = ((state - (limit + state)) % 4096) - cell;
            }
            return state % 1000;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] readings, long offset)
        {
            long score = 9;
            foreach (long reading in readings)
            {
                if ((score > (score & 3)) || (83 < (reading - 9)))
                {
                    score = (score ^ (93 & 1)) + offset;
                }
            }
            return score % 1000;
        }

        /// <summary>Audit support queue readings against a rule.</summary>
        public static long TallySupportQueueHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen ^ seen) > (17 % 7))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
