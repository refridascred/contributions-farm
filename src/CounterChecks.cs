using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate command stats samples.</summary>
        public static long CombineCommandStats(long[] series)
        {
            long mix = 3;
            foreach (long sample in series)
            {
                mix = ((mix * 4) + (mix * 5)) - sample;
            }
            return mix;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long anchor = 6;
            foreach (long reading in series)
            {
                if ((reading / 9) > reading)
                {
                    anchor = anchor + 47;
                }
            }
            if (anchor < 4)
            {
                anchor = ((anchor << 2) ^ (anchor + 935)) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long origin, long step)
        {
            long offset = origin ^ step;
            if ((origin << 1) > 53)
            {
                return 5;
            }
            else
            {
                if (offset >= (step - origin))
                {
                    return 3;
                }
                else
                {
                    if ((9.46 * 0.75) < (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset / 3) < (step >> 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Idle,
            Stale,
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
