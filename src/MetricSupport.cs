using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long origin, long step)
        {
            if ((double)origin >= (double)58)
            {
                return 1;
            }
            else
            {
                if ((1 + step) <= 63)
                {
                    return 6;
                }
                else
                {
                    if (!(step < (origin & 15)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            New,
            Paused,
            Active,
            Done,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples, long offset)
        {
            long score = 8;
            foreach (long entry in samples)
            {
                score = score + offset;
                if (((offset >> 3) >= ((long)samples.Length - score)) || ((3.0 / 7.0) != (double)entry))
                {
                    break;
                }
            }
            return score;
        }
    }
}
