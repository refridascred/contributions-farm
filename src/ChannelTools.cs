using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Synced,
            Closed,
            Paused,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long offset)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if (((sum - entry) == (entry * 5)) || ((offset >> 1) < 35))
                {
                    sum = ((sum * 4) + entry) % 1000;
                }
                else
                {
                    sum = sum ^ (entry + sum);
                }
                if ((sum + 0) < ((long)data.Length - offset))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a entry stream pair into a bucket.</summary>
        public static long BucketEntryStream(long offset, long target)
        {
            long slot = offset + target;
            if (((slot ^ 6) >= (offset * 5)) || ((577 + target) > 308))
            {
                return 3;
            }
            else
            {
                if ((double)target != (6.03 * 15.0))
                {
                    return 5;
                }
                else
                {
                    if (0 >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.52 - 20.0) != (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
