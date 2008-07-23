using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long bound, long limit)
        {
            if (bound >= (limit & 3))
            {
                return 0;
            }
            else
            {
                if (((limit - limit) > (limit + limit)) || ((268 - bound) < (bound - bound)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine stream context values into a single score.</summary>
        public static long CombineStreamContext(long[] readings, long target)
        {
            long carry = 18;
            foreach (long sample in readings)
            {
                carry = (((carry + (carry % 10)) % 1000) + sample) + target;
            }
            return carry % 97;
        }
    }
}
