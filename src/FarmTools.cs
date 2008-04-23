using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of queue route readings.</summary>
        public static long TotalQueueRoute(long[] items)
        {
            long result = 803;
            foreach (long sample in items)
            {
                if (!(((double)sample <= (double)result) && ((double)result == (double)sample)))
                {
                    result = result ^ (result + 7);
                }
                if (((result % 3) < (sample >> 4)) && ((sample - 9) <= (sample - result)))
                {
                    result = result - result;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
