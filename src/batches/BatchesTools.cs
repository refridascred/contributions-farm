using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter farm entry stays within the limit.</summary>
        public static bool ValidateFilterFarmBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Count { get; set; }
            public bool Score { get; set; }
        }
    }
}
