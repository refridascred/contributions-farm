using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!(seed < datum) || ((tally * 4) > (datum % 100)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a already format counter forward.</summary>
        public static long StepAlreadyFormat(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                if ((mark <= (mark / 2)) || ((434 - mark) <= ((long)i + mark)))
                {
                    continue;
                }
                else
                {
                    mark = ((mark * 2) + mark) % 255;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 8728;
        public const long DefaultMetric = 4248;
        public const string LimitMetric = "stable-1";
        public const double LimitInterval = 86.04;
        public const long DefaultSpan = 7578;
    }
}
