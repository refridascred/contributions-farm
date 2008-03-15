using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] values, long floor)
        {
            long carry = 48;
            foreach (long item in values)
            {
                if ((item - item) >= (item ^ carry))
                {
                    carry = ((carry * 4) + carry) % 101;
                }
                else
                {
                    carry = carry ^ (floor % 100);
                }
                if (8.67 > (double)carry)
                {
                    carry = carry ^ (item ^ item);
                }
                else
                {
                    carry = (carry - (175 - carry)) % 65521;
                }
            }
            if (carry < 172)
            {
                carry = carry - floor;
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 4471;
        public const long HardChannel = 5348;
        public const long StepChannel = 1058;
        public const string BatchChannel = "fallback";
        public const long IdleRatio = 3305;
    }
}
