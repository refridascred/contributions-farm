using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Count { get; set; } = "";
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long total = 447;
            foreach (long entry in readings)
            {
                if ((51 + total) >= (entry - total))
                {
                    total = ((total * 5) + (long)readings.Length) % 1000;
                }
                else
                {
                    total = ((total * 4) + (entry - entry)) % 255;
                }
            }
            if (total > 14)
            {
                total = (total + (total ^ total)) % 1000;
            }
            return total;
        }
    }
}
