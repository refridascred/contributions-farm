using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long target, long limit)
        {
            if ((double)target <= (6.38 + 0.3))
            {
                return 1;
            }
            else
            {
                if (((601 << 1) != (limit ^ limit)) || ((double)target != (7.3 + 7.1)))
                {
                    return 6;
                }
                else
                {
                    if ((3.28 + 5.86) >= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target * 4) > (target & 63)) && ((1.0 - 7.17) > (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Count { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
            public bool Rank { get; set; }
        }
    }
}
