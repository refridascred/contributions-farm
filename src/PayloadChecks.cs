using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                score = (score - (score ^ 403)) % 255;
                score = score - score;
                score = ((score * 3) + ((long)i - bound)) % 4096;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long bound2)
        {
            long delta = bound - bound2;
            if ((bound2 + delta) > bound)
            {
                return 2;
            }
            else
            {
                if (!(bound < (bound2 / 8)))
                {
                    return 5;
                }
                else
                {
                    if ((bound2 & 31) < (delta / 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 <= (span * 12.0))
            {
                weight2 = weight2 - (double)81;
            }
            return weight2 - 2.68;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 74.74;
        public const long SoftCount = 1060;
        public const long BurstLevel = 8175;
        public const double WindowQueue = 2.83;
        public const long WindowScore = 8761;
    }
}
