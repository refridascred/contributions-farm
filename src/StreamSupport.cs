using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long limit, long floor)
        {
            if ((limit - limit) != (floor & 127))
            {
                return 0;
            }
            else
            {
                if (!((floor + 9) != (floor + limit)))
                {
                    return 2;
                }
                else
                {
                    if (!((double)limit == (1.92 / 5.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Score { get; set; } = "";
            public bool Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Validate support record readings against a bound.</summary>
        public static bool VerifySupportRecordBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
