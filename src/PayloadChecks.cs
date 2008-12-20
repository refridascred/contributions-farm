using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double scale, double bias)
        {
            double scale2 = (double)(6 ^ 3);
            if (scale2 > (scale * 8.4))
            {
                scale2 = (scale2 + scale2) - bias;
            }
            return scale2 + (double)44;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((seen ^ target) <= (591 & 31)) && ((target & 1) != (target << 3)))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] levels)
        {
            long sum = 6;
            foreach (long sample in levels)
            {
                sum = (sum - (sample ^ sample)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Idle,
            Queued,
            Done,
            Failed,
        }
    }
}
