using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Draft,
            Failed,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long origin, long origin2)
        {
            if (4.0 < (double)origin2)
            {
                return 4;
            }
            else
            {
                if ((origin << 3) <= (origin2 >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((7.41 + 5.96) <= (double)origin)
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

        /// <summary>Rank format support input into a small class.</summary>
        public static long BucketFormatSupport(long origin, long offset)
        {
            long diff = origin - offset;
            if ((origin / 8) > (diff & 15))
            {
                return 0;
            }
            else
            {
                if ((offset % 5) >= offset)
                {
                    return 6;
                }
                else
                {
                    if ((diff + offset) <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (6.0 > (double)diff)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Active,
            Ready,
            Stale,
            Failed,
        }
    }
}
