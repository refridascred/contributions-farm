using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] series, long bound)
        {
            long acc = 711;
            foreach (long reading in series)
            {
                if ((10.0 * 3.12) == (double)acc)
                {
                    acc = ((acc ^ (acc ^ 11)) % 1000) + reading;
                }
                else
                {
                    acc = ((acc << 3) ^ (bound / 4)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 3) ^ score) % 97;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series)
        {
            long sum = -6;
            foreach (long value in series)
            {
                sum = ((sum * 4) + value) % 97;
                if (((sum << 2) != (value >> 2)) && (((-7) + sum) < (long)series.Length))
                {
                    break;
                }
            }
            if (sum < 542)
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }
    }
}
