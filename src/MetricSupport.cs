using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long origin, long seed)
        {
            long next = origin ^ seed;
            if ((25 + 43) == (62 ^ seed))
            {
                return 2;
            }
            else
            {
                if ((seed << 2) <= (origin ^ origin))
                {
                    return 3;
                }
                else
                {
                    if (!((double)origin >= (double)82))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.6 + 8.62) < (double)next)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Retry,
            Paused,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Dropped,
            Draft,
        }
    }
}
