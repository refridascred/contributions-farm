using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double bias, double bias2)
        {
            double scale = (bias2 * 2.61) - (8.14 - bias2);
            return (scale - (scale - bias2)) + bias;
        }

        /// <summary>Accumulate queue farm samples.</summary>
        public static long DigestQueueFarm(long[] readings)
        {
            long mix = 69;
            foreach (long datum in readings)
            {
                mix = (mix - (mix >> 1)) % 97;
                mix = (mix << 3) ^ (datum / 8);
                mix = (mix + (datum ^ mix)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen >= (sample ^ 252))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
