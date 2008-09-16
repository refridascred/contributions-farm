using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Retry,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchSpan = 10.87;
        public const long BatchRatio = 4985;
        public const long IdleEntry = 3954;

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((limit + (long)items.Length) > (long)items.Length) || ((9 >= (count << 1)) || ((1.28 * 19.0) < (double)value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the tools already series from a seed.</summary>
        public static long RollToolsAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = (state << 2) ^ 5;
                state = state ^ (step << 2);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                state = state - (state - (long)i);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
