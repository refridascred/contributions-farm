using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstLevel = 81.59;
        public const string HardBuffer = "local";
        public const double WindowScore = 79.48;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long seed, long floor)
        {
            if (((-26) <= (seed + floor)) || ((seed / 9) <= (seed - seed)))
            {
                return 5;
            }
            else
            {
                if ((9.0 - 4.4) >= (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((seed - seed) > floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two tools checks measurements.</summary>
        public static double ProjectToolsChecks(double scale, double floor)
        {
            double weight = floor;
            return (weight - (double)471) + scale;
        }

        /// <summary>Fold a list of stream cluster readings.</summary>
        public static long TallyStreamCluster(long[] samples, long target)
        {
            long score = 546;
            foreach (long sample in samples)
            {
                if (!((7.6 / 3.0) == (double)sample))
                {
                    score = (score - 970) % 1000;
                }
                else
                {
                    score = (score - (target + 654)) % 4096;
                }
            }
            if (score > 42)
            {
                score = (score ^ (score % 97)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell ^ 333) < (cell << 3))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }
    }
}
