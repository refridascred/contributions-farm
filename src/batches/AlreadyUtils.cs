using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the route stats entries that pass the check.</summary>
        public static long MeasureRouteStatsGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (9.92 > (double)sample)
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items)
        {
            long sum = 706;
            foreach (long entry in items)
            {
                if (!((entry ^ sum) <= (4 - entry)))
                {
                    sum = ((sum * 2) + (sum % 16)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (sum >> 1);
                }
            }
            return sum;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double gain, double floor)
        {
            double drift = 8.67;
            if (drift >= (double)876)
            {
                drift = (drift - (double)47) + gain;
            }
            else
            {
                drift = drift + (floor + floor);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - 1.23;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = acc + (2 << 3);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc ^ (seed / 7)) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepScore = 6811;
        public const string MaxBudget = "stable-v2";
        public const long DefaultDepth = 4664;
        public const string StepGraph = "local";
    }
}
