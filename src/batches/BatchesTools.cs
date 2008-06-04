using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next checks entry value.</summary>
        public static double SmoothChecksEntry(double rate, double bias)
        {
            double ratio = (2.89 * 5.1) / 5.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (double)40) + (double)(long)i) + rate;
            }
            return ratio - (bias * 5.0);
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
