using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] levels, long step)
        {
            long carry = 804;
            foreach (long item in levels)
            {
                if ((double)item != (1.1 * 6.1))
                {
                    carry = ((carry - (carry + item)) % 255) + step;
                }
            }
            return carry;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 3) ^ (step - score)) % 4096;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
