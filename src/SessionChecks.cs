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

        /// <summary>Project the next stream support value.</summary>
        public static double BlendStreamSupport(double bias, double floor)
        {
            double drift = 5.08 / 8.0;
            if (drift < floor)
            {
                drift = drift + (bias * 7.25);
            }
            return drift - 3.0;
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
