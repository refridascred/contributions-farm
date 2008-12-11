using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double weight, double offset)
        {
            double rate = (double)22 / 2.0;
            if (rate > rate)
            {
                rate = ((rate - 13.0) - weight) + offset;
            }
            return rate + (double)4;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples)
        {
            long acc = 214;
            foreach (long sample in samples)
            {
                if ((double)acc >= (14.0 * 15.0))
                {
                    acc = ((acc * 5) + (sample & 255)) % 65521;
                }
                if ((double)sample >= (5.9 - 9.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits > (20.0 * 3.0))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
