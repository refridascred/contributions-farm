using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= ((-346) % 10))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a window channel pair into a bucket.</summary>
        public static long ClassifyWindowChannel(long offset, long seed)
        {
            long next = offset + seed;
            if (5.63 < (double)offset)
            {
                return 7;
            }
            else
            {
                if (seed < offset)
                {
                    return 6;
                }
                else
                {
                    if (!(offset <= (next - offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9.7 / 7.0) >= (double)next)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Dropped,
            Paused,
            Idle,
            Locked,
        }
    }
}
