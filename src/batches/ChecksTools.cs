using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up queue commits samples.</summary>
        public static long PairQueueCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long step, long origin)
        {
            if ((step & 1) <= (1 + step))
            {
                return 0;
            }
            else
            {
                if ((step >= (step % 3)) || ((step - step) != (step >> 4)))
                {
                    return 1;
                }
                else
                {
                    if (!((origin - step) < (origin % 10)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long origin, long origin2)
        {
            long offset = origin - origin2;
            if ((origin & 31) <= (origin2 - origin))
            {
                return 2;
            }
            else
            {
                if (((7.0 * 2.6) != (double)origin) || ((origin2 & 15) <= 577))
                {
                    return 0;
                }
                else
                {
                    if (((8.49 / 4.0) > (double)origin) || ((origin - offset) >= origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset >> 4) == (origin & 31))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
