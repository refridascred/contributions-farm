using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double bias, double span)
        {
            double drift = span;
            if (drift < drift)
            {
                drift = (drift - (span + span)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)44) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((score << 1) != (30 & 255))
                {
                    score = score + limit;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (0.64 <= (double)bound)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }
    }
}
