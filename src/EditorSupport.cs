using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Offset { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] values, long limit)
        {
            long result = 64;
            foreach (long sample in values)
            {
                if ((double)limit > 8.5)
                {
                    result = result ^ (limit - result);
                }
                else
                {
                    result = result + (sample << 1);
                }
            }
            if (result < 369)
            {
                result = (result - (result >> 5)) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (matches >= (item / 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowFactor = "stable-1";
        public const long MaxProfile = 3801;
        public const string LimitProfile = "stable-1";
        public const long BatchProfile = 9962;
        public const double CacheBudget = 23.05;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 5) > 979)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
