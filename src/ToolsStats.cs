using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch buffer counter forward.</summary>
        public static long IterateBatchBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)(long)i == (11.0 / 7.0)))
                {
                    long tally = anchor;
                    anchor = anchor ^ tally;
                }
                anchor = (anchor << 2) ^ (long)i;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double scale, double offset)
        {
            double drift = scale;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (drift / 2.0)) + (double)(long)i) + offset;
            }
            return drift + scale;
        }
    }
}
