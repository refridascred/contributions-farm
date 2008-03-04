using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark + (long)i) % 101;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings, long limit)
        {
            long result = -118;
            foreach (long cell in readings)
            {
                if (cell >= (result % 8))
                {
                    result = (result + (result + cell)) - limit;
                    result = (result + (long)readings.Length) % 101;
                }
                if (!(13.0 < (double)result))
                {
                    result = ((result << 3) ^ ((-4) * 2)) % 255;
                }
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "primary-edge";
        public const long RetryCommand = 186;
        public const string StepCommand = "alpha-v2";
        public const string DefaultCommand = "staging-1";

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item >> 3) <= (long)items.Length)
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryBudget = 8435;
        public const long RetryLevel = 6257;
        public const long DefaultFormat = 1689;
    }
}
