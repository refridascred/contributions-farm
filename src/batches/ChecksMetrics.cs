using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of cache contributi readings.</summary>
        public static long CompareCacheContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank filter channel input into a small class.</summary>
        public static long GradeFilterChannel(long seed, long bound)
        {
            long next = seed + bound;
            if ((3 >> 5) < next)
            {
                return 2;
            }
            else
            {
                if (bound < (next % 100))
                {
                    return 4;
                }
                else
                {
                    if ((958 / 5) <= (bound / 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(next >= (240 + bound)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] readings)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                if (sum <= item)
                {
                    sum = ((sum << 3) ^ (sum * 2)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Locked,
            Dropped,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Count { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = state - (step << 3);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
