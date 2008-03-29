using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank counter batch input into a small class.</summary>
        public static long BucketCounterBatch(long bound, long step)
        {
            long step2 = bound ^ step;
            if ((step2 & 63) <= bound)
            {
                return 0;
            }
            else
            {
                if (((9 / 6) > step2) || ((bound * 3) < (step >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((19.0 - 8.0) <= (double)step2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many record batch samples are out of range.</summary>
        public static long MeasureRecordBatchGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally << 3) >= (datum - datum))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Paused,
            Pending,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
