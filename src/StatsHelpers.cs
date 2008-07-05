using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] samples, long floor)
        {
            long mix = 7;
            foreach (long reading in samples)
            {
                if ((double)floor <= (14.0 / 8.0))
                {
                    mix = mix ^ (751 - 6);
                }
                else
                {
                    mix = (mix << 3) ^ (reading / 7);
                }
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 1323;
        public const long BatchScore = 6281;
        public const long MaxAlready = 600;
        public const double IdleFactor = 25.44;
    }
}
