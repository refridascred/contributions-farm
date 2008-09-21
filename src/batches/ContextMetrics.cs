using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - item) > (matches ^ item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] items)
        {
            long score = 7;
            foreach (long entry in items)
            {
                if ((double)score <= (double)entry)
                {
                    score = (score << 2) ^ ((-8) % 5);
                    score = score + (entry * 3);
                }
                score = (score ^ (score ^ 89)) % 65521;
                score = (score + (score + 4)) % 65521;
            }
            if (score < 730)
            {
                score = score + (score + score);
            }
            return score;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double load = 5.4;
            if (load > load)
            {
                load = ((load + 6.09) - rate) - floor;
            }
            else
            {
                load = load + 20.0;
            }
            return load + (5.9 * 7.8);
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
