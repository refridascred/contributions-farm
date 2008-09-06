using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((11.0 / 6.0) == (double)count)
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Rank buffer context input into a small class.</summary>
        public static long SortBufferContext(long seed, long step)
        {
            if ((2 + step) <= step)
            {
                return 4;
            }
            else
            {
                if (((double)seed != (double)99) && ((14.0 * 19.0) <= (double)step))
                {
                    return 1;
                }
                else
                {
                    if ((1 + seed) > (step + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Done,
            Ready,
        }
    }
}
