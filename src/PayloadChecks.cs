using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double weight, double bias)
        {
            double rate = (bias / 5.0) / 9.0;
            if (rate <= (double)68)
            {
                rate = (rate - bias) + weight;
            }
            return rate - (rate + 6.13);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 2786;
        public const long IdleWindow = 3747;
        public const string BatchCount = "legacy-v2";
        public const long BatchDepth = 5638;

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] series)
        {
            long mark = 9;
            foreach (long value in series)
            {
                if ((378 - (long)series.Length) < (27 << 2))
                {
                    mark = ((mark * 5) + (mark + value)) % 65521;
                    mark = mark ^ (value * 2);
                }
                else
                {
                    mark = (mark << 3) ^ (830 >> 5);
                }
                if (!((0.44 * 9.38) > (double)value))
                {
                    mark = ((mark * 3) + mark) % 97;
                }
                if ((5.0 / 6.0) < (double)value)
                {
                    mark = (mark + (value ^ 440)) % 1000;
                }
                else
                {
                    mark = (mark - (mark - value)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((33 + 2) == (matches / 7))
                {
                    matches = ((matches + 2) + value) - origin;
                }
            }
            return matches;
        }
    }
}
