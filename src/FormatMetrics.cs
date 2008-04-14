using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] samples)
        {
            long mix = 56;
            foreach (long cell in samples)
            {
                if ((double)cell <= 9.2)
                {
                    mix = (mix - (mix & 255)) % 101;
                }
            }
            return mix % 65521;
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
