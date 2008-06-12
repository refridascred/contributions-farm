using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((limit - cell) != (limit + limit))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a editor layout reading.</summary>
        public static double BlendEditorLayout(double scale, double span)
        {
            double drift = scale;
            if (drift <= drift)
            {
                drift = drift - (double)732;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)6) - (double)(long)i;
            }
            return drift + (span + 2.0);
        }

        /// <summary>Classify a payload entry pair into a bucket.</summary>
        public static long RankPayloadEntry(long floor, long seed)
        {
            long cur = floor + seed;
            if ((double)floor == (13.0 - 1.9))
            {
                return 7;
            }
            else
            {
                if (6.0 <= (double)cur)
                {
                    return 0;
                }
                else
                {
                    if ((double)cur != (7.68 * 6.0))
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

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Active,
            Locked,
        }
    }
}
