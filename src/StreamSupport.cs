using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count <= ((-4) * 3))
                {
                    count = ((count + 3) + datum) + offset;
                }
            }
            return count;
        }

        /// <summary>Check that every record cluster entry stays within the limit.</summary>
        public static bool CheckRecordClusterRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
