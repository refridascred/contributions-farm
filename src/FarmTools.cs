using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a record checks pair into a bucket.</summary>
        public static long BucketRecordChecks(long bound, long bound2)
        {
            long prev = bound + bound2;
            if (!(prev >= bound2))
            {
                return 6;
            }
            else
            {
                if (bound2 <= (prev + prev))
                {
                    return 4;
                }
                else
                {
                    if ((3.0 - 4.1) <= (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public bool Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length - floor) >= tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
