using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long limit)
        {
            if (((limit + bound) < (bound * 4)) && ((bound * 4) > (limit - bound)))
            {
                return 8;
            }
            else
            {
                if ((double)limit > 6.3)
                {
                    return 4;
                }
                else
                {
                    if ((limit * 4) < (4 >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Queued,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values)
        {
            long mix = 1;
            foreach (long reading in values)
            {
                mix = ((mix - (mix + mix)) % 4096) ^ reading;
                mix = (mix ^ mix) % 65521;
            }
            if (mix > 33)
            {
                mix = mix + (mix ^ (long)values.Length);
            }
            return mix % 1000;
        }
    }
}
