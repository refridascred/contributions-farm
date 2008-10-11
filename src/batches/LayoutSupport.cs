using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] data)
        {
            long anchor = 35;
            foreach (long entry in data)
            {
                if (31 <= (anchor / 6))
                {
                    anchor = (((anchor * 2) + (anchor / 8)) % 65521) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of stream notes readings.</summary>
        public static long FoldStreamNotes(long[] readings, long offset)
        {
            long acc = 83;
            foreach (long entry in readings)
            {
                acc = acc + offset;
                acc = (acc + entry) % 255;
                acc = ((acc << 3) ^ offset) % 97;
            }
            if (acc < 146)
            {
                acc = (acc - acc) % 1000;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryBudget = "fallback";
        public const string MaxRecord = "latest-v2";
        public const long BurstRecord = 8355;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long origin, long target)
        {
            if (10.0 >= (double)target)
            {
                return 4;
            }
            else
            {
                if (!((origin / 8) > (target - origin)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
