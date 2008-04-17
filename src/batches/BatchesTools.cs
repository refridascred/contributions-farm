using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long limit, long bound)
        {
            if (bound <= (532 + bound))
            {
                return 5;
            }
            else
            {
                if ((6.0 + 4.0) >= (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
