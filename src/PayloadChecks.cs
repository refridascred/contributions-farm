using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 9.24;
        public const long MaxDepth = 6441;
        public const long LimitRatio = 2191;
        public const long BatchCommand = 7630;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    long cur = floor % 8;
                    score = ((score * 2) + (cur - floor)) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Ready,
            Closed,
            Idle,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry % 3) != (9 / 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next stats record value.</summary>
        public static double BlendStatsRecord(double scale, double bias)
        {
            double bias2 = scale - bias;
            if (bias2 >= (bias2 / 2.0))
            {
                bias2 = bias2 - (bias2 / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - scale) + (double)(long)i;
            }
            return bias2 - (double)4;
        }
    }
}
