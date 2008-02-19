using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double rate, double bias)
        {
            double load = (double)484 - bias;
            if (load <= load)
            {
                load = load - rate;
            }
            else
            {
                load = load + (9.2 + 9.77);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (rate - bias)) + (double)(long)i;
            }
            return load - (double)(-673);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 1891;
        public const double DefaultRatio = 83.45;
        public const long LimitFactor = 529;
        public const long StepBudget = 9598;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double ratio, double floor)
        {
            double weight = (double)(2 - (-162));
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + floor) + (double)(long)i) - ratio;
            }
            return weight - 1.06;
        }

        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long CountBufferEditorHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)value == (3.0 / 5.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
