using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] series, long floor)
        {
            long score = -438;
            foreach (long entry in series)
            {
                if ((499 / 4) > (score ^ score))
                {
                    score = (score + (score - entry)) - floor;
                    score = ((score * 5) + (score ^ 712)) % 4096;
                }
                score = score - (5 ^ score);
            }
            return score % 97;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double gain, double bias)
        {
            double bias2 = 1.11;
            if (bias2 >= (double)14)
            {
                bias2 = (bias2 - bias) + gain;
            }
            else
            {
                bias2 = bias2 - 3.89;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}
