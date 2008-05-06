using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((long)data.Length + matches) < (0 * 2)) && ((71 / 6) == (entry - entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long limit, long step)
        {
            long slot = limit + step;
            if ((step >> 3) == (step * 4))
            {
                return 8;
            }
            else
            {
                if (((3.96 * 7.0) >= (double)limit) || (limit <= step))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit >= (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((slot ^ slot) < slot)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long result = 56;
            foreach (long reading in levels)
            {
                result = ((result - (921 + result)) % 97) - reading;
                result = result ^ result;
            }
            return result % 4096;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Paused,
            Locked,
            Synced,
            Dropped,
        }
    }
}
