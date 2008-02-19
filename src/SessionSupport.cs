using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchBudget = 7773;
        public const long LimitFilter = 6025;
        public const long MinFilter = 4073;
        public const double MaxFilter = 44.65;
        public const string BatchSpan = "fallback-1";

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double span)
        {
            double bias = span;
            if (bias <= (span * 12.0))
            {
                bias = bias - (rate / 2.0);
            }
            else
            {
                bias = bias + (rate - rate);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + rate) - (double)(long)i;
            }
            return bias - rate;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
