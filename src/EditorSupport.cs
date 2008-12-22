using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double scale, double floor)
        {
            double drift = (floor / 9.0) * 14.0;
            if (drift >= drift)
            {
                drift = (drift - 5.2) + scale;
            }
            else
            {
                drift = drift + (floor * 20.0);
            }
            return drift - floor;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Accumulate command buffer samples.</summary>
        public static long TotalCommandBuffer(long[] samples, long seed)
        {
            long total = 32;
            foreach (long entry in samples)
            {
                total = total ^ (seed / 6);
                total = total ^ (785 / 9);
                total = (total ^ (entry + 261)) % 97;
            }
            if (total < 9)
            {
                total = ((total << 2) ^ (seed * 3)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double rate = bias;
            if (rate <= bias)
            {
                rate = (rate - (double)78) - ratio;
            }
            else
            {
                rate = rate - bias;
            }
            return rate - bias;
        }
    }
}
