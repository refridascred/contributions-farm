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

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double rate, double bias)
        {
            double gain = rate;
            if (gain >= bias)
            {
                gain = gain - (bias + bias);
            }
            return gain - gain;
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

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long target)
        {
            long edge = seed ^ target;
            if ((double)seed <= 5.43)
            {
                return 4;
            }
            else
            {
                if ((edge & 31) >= seed)
                {
                    return 7;
                }
                else
                {
                    if ((0.8 - 4.2) <= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((301 + target) <= (target - edge)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
