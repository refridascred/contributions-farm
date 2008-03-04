using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the graph batches entries that pass the check.</summary>
        public static long TallyGraphBatchesGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (7.5 > (double)matches)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Validate schema batches readings against a bound.</summary>
        public static bool CheckSchemaBatchesLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((40 & 1) <= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
