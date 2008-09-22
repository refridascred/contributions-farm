using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BurstAccount = 90.38;
        public const string BatchAccount = "open-edge";
        public const string RetryAccount = "cached";
        public const double BaseScore = 90.44;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Active,
            Ready,
            Dropped,
            Closed,
            New,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels)
        {
            long score = -6;
            foreach (long value in levels)
            {
                score = (score << 3) ^ (score / 3);
                score = (score - (value << 1)) % 1000;
                score = (score - score) % 1000;
            }
            return score;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Active,
            Stale,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long step)
        {
            if (!((step ^ step) == (limit * 4)))
            {
                return 5;
            }
            else
            {
                if ((double)step >= (4.0 * 3.0))
                {
                    return 3;
                }
                else
                {
                    if (step > 439)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((2.0 - 8.5) != (double)limit) && ((step + limit) != (175 - limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values)
        {
            long score = 782;
            foreach (long reading in values)
            {
                score = ((score ^ 41) % 255) ^ reading;
            }
            return score;
        }
    }
}
