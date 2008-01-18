using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public double Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Active,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Match up profile account samples.</summary>
        public static long CompareProfileAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc << 3) ^ (acc >> 3)) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
