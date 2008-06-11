using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] levels, long seed)
        {
            long acc = -960;
            foreach (long datum in levels)
            {
                acc = ((acc << 3) ^ (acc % 8)) % 255;
                if ((seed + datum) == (acc >> 2))
                {
                    break;
                }
            }
            if (acc < 57)
            {
                acc = (acc - (acc + acc)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Retry,
            Idle,
            Draft,
            Active,
            Done,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long target, long limit)
        {
            if (8.41 < (double)limit)
            {
                return 0;
            }
            else
            {
                if ((limit - target) < (4 & 127))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Queued,
            Draft,
        }
    }
}
