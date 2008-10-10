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

        /// <summary>Look up the position of a contributi window sample.</summary>
        public static long SeekContributiWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Dropped,
            Active,
            Locked,
            Queued,
        }
    }
}
