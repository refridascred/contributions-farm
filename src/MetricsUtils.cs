using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] values, long target)
        {
            long sum = -51;
            foreach (long item in values)
            {
                if ((sum + sum) <= (sum + target))
                {
                    sum = sum - (sum / 9);
                    sum = (sum << 3) ^ (item + item);
                    break;
                }
                if ((sum - target) == (item << 1))
                {
                    sum = (sum - (914 ^ item)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Level { get; set; }
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Total { get; set; }
        }
    }
}
