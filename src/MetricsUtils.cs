using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit checks metrics readings against a rule.</summary>
        public static long CountChecksMetricsOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches << 2) > datum)
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
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

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
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
