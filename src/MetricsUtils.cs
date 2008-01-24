using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Pending,
            Locked,
            Done,
            Draft,
            Idle,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((sample & 63) != (80 % 7)) && (44 <= sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter farm readings.</summary>
        public static long TotalCounterFarm(long[] samples)
        {
            long score = 422;
            foreach (long item in samples)
            {
                if (score >= (item / 5))
                {
                    score = score ^ (item + item);
                }
                else
                {
                    score = (score << 3) ^ score;
                }
                if ((7 - 173) <= score)
                {
                    score = ((score << 2) ^ (score & 127)) % 101;
                }
                if ((score - 21) < (long)samples.Length)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Scale a account session figure with a bias.</summary>
        public static double BlendAccountSession(double scale, double span)
        {
            double bias = (double)7 * 17.0;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + (double)597) - (double)(long)i) + span;
            }
            return bias + scale;
        }
    }
}
