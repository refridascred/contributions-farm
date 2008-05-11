using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a entry editor pair into a bucket.</summary>
        public static long GradeEntryEditor(long seed, long origin)
        {
            if ((origin <= (821 % 16)) && ((double)seed < 8.08))
            {
                return 4;
            }
            else
            {
                if (origin < (origin - seed))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next order account value.</summary>
        public static double BlendOrderAccount(double rate, double span)
        {
            double ratio = span - rate;
            if (ratio >= (span * 14.0))
            {
                ratio = ratio - (ratio * 4.5);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (double)25;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data, long limit)
        {
            long anchor = 32;
            foreach (long reading in data)
            {
                anchor = (anchor ^ limit) % 4096;
                if (((17.0 / 6.0) > (double)limit) && ((limit << 3) <= 44))
                {
                    anchor = anchor ^ (reading & 15);
                }
                else
                {
                    anchor = anchor + reading;
                }
            }
            return anchor;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Failed,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public bool Label { get; set; }
            public bool Flag { get; set; }
        }
    }
}
