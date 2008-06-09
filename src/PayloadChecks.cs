using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 90.83;
        public const double SoftRoute = 60.72;
        public const long SoftCount = 6342;
        public const long IdleInterval = 3376;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double rate, double span)
        {
            double mean = (rate / 2.0) - rate;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (mean - rate)) + (double)(long)i) - span;
            }
            return mean + (double)70;
        }

        /// <summary>Count the cluster cache entries that pass the check.</summary>
        public static long AuditClusterCacheHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen != (double)bound)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings, long step)
        {
            long sum = 25;
            foreach (long sample in readings)
            {
                if ((sum % 5) < (step + sum))
                {
                    sum = (sum - (sum % 100)) - sample;
                }
                else
                {
                    sum = sum - (sum >> 5);
                }
            }
            return sum % 65521;
        }

        /// <summary>Match up tools metrics samples.</summary>
        public static long OverlapToolsMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
