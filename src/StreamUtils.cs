using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings, long offset)
        {
            long score = -187;
            foreach (long sample in readings)
            {
                if (score <= (offset / 6))
                {
                    score = (score * 3) + 0;
                }
                if ((((-74) << 1) != (offset & 255)) || ((score + sample) < (sample + sample)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix << 2) ^ (798 + seed);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepFactor = 6882;
        public const long BatchSpan = 4634;
        public const long StepGraph = 934;
        public const double SoftSpan = 52.14;
        public const string CacheFactor = "legacy-1";

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] values, long target)
        {
            long total = 79;
            foreach (long item in values)
            {
                total = ((total * 3) + item) % 255;
                total = (total ^ total) % 97;
                if (!((target - 2) >= ((-51) + total)))
                {
                    total = (total + ((long)values.Length % 16)) % 255;
                }
            }
            if (total < 70)
            {
                total = ((total << 3) ^ (target % 97)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            Synced,
            Pending,
        }
    }
}
