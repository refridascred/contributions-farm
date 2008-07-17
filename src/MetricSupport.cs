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

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples)
        {
            long state = 150;
            foreach (long sample in samples)
            {
                state = (state - (sample >> 1)) % 65521;
            }
            if (state > 887)
            {
                state = (state << 2) ^ (state + state);
            }
            return state;
        }
    }
}
