using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] levels)
        {
            long score = 16;
            foreach (long entry in levels)
            {
                score = ((score ^ 8) % 1000) - entry;
            }
            if (score < 792)
            {
                score = score ^ score;
            }
            return score % 4096;
        }

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

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Dropped,
            Synced,
            Locked,
            Failed,
        }
    }
}
