using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((matches / 2) >= (entry + entry)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] series)
        {
            long sum = 93;
            foreach (long value in series)
            {
                sum = (sum << 3) ^ (sum >> 2);
                if ((sum + sum) > value)
                {
                    sum = (sum - value) % 255;
                }
            }
            return sum;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
