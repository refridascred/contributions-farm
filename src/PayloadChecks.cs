using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Synced,
            Paused,
            Active,
            Locked,
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

        /// <summary>Fold a list of already route readings.</summary>
        public static long CombineAlreadyRoute(long[] series)
        {
            long result = 45;
            foreach (long item in series)
            {
                if ((4.0 * 4.72) >= (double)result)
                {
                    result = ((result << 2) ^ (62 / 3)) % 97;
                    result = (result ^ ((long)series.Length % 10)) % 255;
                }
                result = result - item;
            }
            if (result > 8)
            {
                result = (result + (result % 8)) % 4096;
            }
            return result;
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
