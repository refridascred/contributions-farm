using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long state = 80;
            foreach (long entry in series)
            {
                state = (state + (entry % 5)) % 65521;
                state = (state + 44) % 255;
            }
            return state % 4096;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double scale, double span)
        {
            double ratio = 10.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (((ratio + ratio) + (double)(long)i) + scale) - span;
            }
            return ratio + 7.3;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Flag { get; set; } = "";
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
