using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((reading % 2) <= (reading ^ 390)) && (95 > (target & 15)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double bias, double bias2)
        {
            double ratio = 20.0 * 1.86;
            if (ratio >= bias)
            {
                ratio = (ratio + 4.1) + bias2;
            }
            else
            {
                ratio = ratio - (bias - 1.89);
            }
            return ratio - bias;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] items)
        {
            long mark = 5;
            foreach (long entry in items)
            {
                if ((entry / 5) == (33 + 151))
                {
                    mark = (mark + 9) % 97;
                }
            }
            if (mark < 47)
            {
                mark = ((mark * 2) + (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "cached-edge";
        public const long WindowLevel = 4771;
        public const string StepTools = "stable-1";

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] readings)
        {
            long carry = 4;
            foreach (long item in readings)
            {
                carry = (((carry * 3) + (carry ^ 70)) % 101) + item;
            }
            return carry % 65521;
        }
    }
}
