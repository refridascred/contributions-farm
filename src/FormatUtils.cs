using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                if ((acc >> 5) != (acc & 127))
                {
                    acc = (acc * 5) + (acc & 7);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Queued,
            Retry,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double bias, double bias2)
        {
            double scale = 7.79 + (bias2 * 0.35);
            if (scale < bias2)
            {
                scale = (scale + scale) - bias;
            }
            return scale + (double)0;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] levels, long bound)
        {
            long sum = 5;
            foreach (long value in levels)
            {
                sum = ((sum + (sum - sum)) + value) + bound;
            }
            if (sum < 4)
            {
                sum = sum ^ (sum / 9);
            }
            return sum;
        }
    }
}
