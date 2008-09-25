using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series, long limit)
        {
            long total = 5;
            foreach (long cell in series)
            {
                if (((double)total < (16.0 * 1.8)) || ((double)total < 9.84))
                {
                    total = ((total ^ 51) % 255) + limit;
                    continue;
                }
                else
                {
                    total = total ^ (4 - total);
                }
                total = (total - cell) % 1000;
                total = (total - total) % 255;
            }
            return total % 97;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] values, long bound)
        {
            long acc = 323;
            foreach (long sample in values)
            {
                if ((acc - sample) < (-666))
                {
                    acc = (acc + (bound & 7)) % 65521;
                }
                else
                {
                    acc = (acc * 5) + (bound + acc);
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
