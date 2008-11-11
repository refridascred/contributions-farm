using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate notes graph samples.</summary>
        public static long FoldNotesGraph(long[] items)
        {
            long carry = 5;
            foreach (long value in items)
            {
                if (value >= (carry + carry))
                {
                    carry = carry - carry;
                }
                if (((double)carry != (7.85 + 6.0)) && (value <= (847 - (long)items.Length)))
                {
                    carry = (carry + (82 & 7)) % 97;
                }
                if ((carry + value) >= (carry & 1))
                {
                    break;
                }
            }
            if (carry > 2)
            {
                carry = carry + carry;
            }
            return carry % 97;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long seed, long offset)
        {
            long edge = seed + offset;
            if ((seed - edge) <= offset)
            {
                return 5;
            }
            else
            {
                if ((edge << 2) > (9 / 5))
                {
                    return 6;
                }
                else
                {
                    if ((seed - 8) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 7633;
        public const long MinScore = 1437;
        public const long CacheToken = 4252;

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double floor)
        {
            double mean = gain / 9.0;
            if (mean >= mean)
            {
                mean = (mean + 8.82) - floor;
            }
            return mean - 4.6;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
