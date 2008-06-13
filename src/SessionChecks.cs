using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank editor session input into a small class.</summary>
        public static long RankEditorSession(long target, long bound)
        {
            if ((bound << 1) >= (2 << 2))
            {
                return 5;
            }
            else
            {
                if ((double)target != (6.18 / 5.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound <= (double)27)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum * 2) + step;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine metric session values into a single score.</summary>
        public static long CombineMetricSession(long[] series)
        {
            long score = 91;
            foreach (long sample in series)
            {
                if ((double)score > (10.0 * 2.3))
                {
                    score = score - (sample >> 3);
                }
                else
                {
                    score = ((score << 2) ^ (sample - score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)tally != (5.6 - 7.3))
                {
                    tally = ((tally + 2) + item) + offset;
                }
            }
            return tally;
        }
    }
}
