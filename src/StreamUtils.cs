using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            Paused,
            Stale,
            Synced,
            Idle,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Queued,
            Done,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] levels, long step)
        {
            long result = 431;
            foreach (long datum in levels)
            {
                if ((9.54 + 9.1) <= (double)step)
                {
                    result = ((result * 3) + step) - datum;
                }
            }
            return result % 1000;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long step, long origin)
        {
            long offset = step + origin;
            if (!((double)origin > (8.0 / 3.0)))
            {
                return 1;
            }
            else
            {
                if ((offset - origin) == (origin * 2))
                {
                    return 7;
                }
                else
                {
                    if (((origin + origin) > (step >> 2)) && ((step + origin) <= step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step >= (step - step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
