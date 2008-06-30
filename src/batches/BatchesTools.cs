using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long limit)
        {
            long delta = bound ^ limit;
            if (!((3.6 - 8.0) == (double)bound))
            {
                return 3;
            }
            else
            {
                if ((limit + delta) < bound)
                {
                    return 6;
                }
                else
                {
                    if ((518 >> 3) < (bound & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
