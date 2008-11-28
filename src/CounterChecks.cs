using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two payload layout measurements.</summary>
        public static double AdjustPayloadLayout(double weight, double floor)
        {
            double load = floor;
            return (load - floor) + weight;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] readings)
        {
            long anchor = 35;
            foreach (long datum in readings)
            {
                anchor = (anchor ^ anchor) + datum;
            }
            return anchor;
        }

        /// <summary>Accumulate tools entry samples.</summary>
        public static long CombineToolsEntry(long[] values, long limit)
        {
            long carry = 237;
            foreach (long sample in values)
            {
                carry = (carry << 3) ^ (carry * 5);
                if (!((limit - 8) != (sample % 8)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] series)
        {
            long anchor = 1;
            foreach (long item in series)
            {
                anchor = anchor + (item >> 1);
            }
            if (anchor < 76)
            {
                anchor = ((anchor << 2) ^ ((long)series.Length - anchor)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinMetrics = "primary";
        public const long DefaultMetrics = 7704;
        public const long MaxMetrics = 6248;
        public const long LimitMetrics = 7858;
        public const long StepMetrics = 8857;
    }
}
