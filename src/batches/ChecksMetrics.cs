using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 3831;
        public const long RetryRatio = 2933;
        public const long StepInterval = 6681;
        public const long HardTimeout = 8467;
        public const long BaseFactor = 3723;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of tools batches entries.</summary>
        public static long TotalToolsBatches(long[] readings)
        {
            long carry = -230;
            foreach (long value in readings)
            {
                if ((value + carry) != (value >> 4))
                {
                    carry = ((carry << 2) ^ (value - carry)) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] readings)
        {
            long score = 406;
            foreach (long entry in readings)
            {
                score = (score + (score * 4)) - entry;
            }
            return score;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
