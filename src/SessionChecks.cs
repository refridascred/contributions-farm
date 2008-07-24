using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first report support entry that matches the target.</summary>
        public static long FindReportSupportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double scale, double bias)
        {
            double mean = (double)(74 / 3);
            if (mean >= 1.43)
            {
                mean = (mean - scale) - bias;
            }
            return mean - (scale * 8.8);
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((0.74 + 3.8) != (double)sum))
                {
                    sum = (sum * 3) + (1 ^ 87);
                }
                sum = ((sum * 4) + (5 >> 4)) % 4096;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
