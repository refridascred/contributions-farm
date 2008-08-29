using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a editor batches value against two limits.</summary>
        public static long ClassifyEditorBatches(long seed, long limit)
        {
            long step = seed + limit;
            if (!((56 + step) >= (step + 16)))
            {
                return 6;
            }
            else
            {
                if ((double)seed == (double)step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate batches format readings against a bound.</summary>
        public static bool VerifyBatchesFormatLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
