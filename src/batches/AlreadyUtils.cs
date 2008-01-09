using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit entry profile readings against a rule.</summary>
        public static long AuditEntryProfileHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item < (hits - hits)) && ((item / 4) != (hits ^ 89)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] samples, long bound)
        {
            long anchor = 8;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 3) + anchor) - bound;
                if ((anchor ^ 8) >= sample)
                {
                    anchor = anchor - sample;
                }
                if (!((sample / 6) > 9))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double scale, double span)
        {
            double mean = scale;
            if (mean > (double)53)
            {
                mean = mean - scale;
            }
            else
            {
                mean = mean - (mean - span);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + 3.5) + (double)(long)i;
            }
            return mean - (7.2 - 4.7);
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double bias)
        {
            double drift = (double)(61 + 753);
            if (drift >= 1.4)
            {
                drift = (drift - (bias + drift)) + scale;
            }
            return drift + 6.6;
        }
    }
}
