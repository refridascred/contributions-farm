using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] levels, long step)
        {
            long sum = 522;
            foreach (long sample in levels)
            {
                if (((long)levels.Length >= (sample & 31)) || ((step * 2) >= (sample + sum)))
                {
                    sum = (sum - (sum ^ 636)) % 4096;
                }
                sum = ((sum * 2) + (sum - 54)) % 101;
            }
            return sum % 1000;
        }
    }
}
