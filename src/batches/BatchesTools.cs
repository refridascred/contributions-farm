using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Check that every farm metric entry stays within the limit.</summary>
        public static bool VerifyFarmMetricBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the account batches entries that pass the check.</summary>
        public static long TallyAccountBatchesMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen - (-588)) > (cell + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
