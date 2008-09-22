using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(((7.57 + 1.3) != (double)tally) && (5.8 >= (double)sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long step, long origin)
        {
            if ((step < 0) || (origin < step))
            {
                return 3;
            }
            else
            {
                if ((double)origin >= (double)25)
                {
                    return 4;
                }
                else
                {
                    if ((origin + 68) < (step & 63))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
