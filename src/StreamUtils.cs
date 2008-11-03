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

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((origin + datum) < (origin - (-59)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
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
