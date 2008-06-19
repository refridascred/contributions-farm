using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double ratio, double floor)
        {
            double load = (double)(99 + 63);
            if (load < floor)
            {
                load = load + 7.37;
            }
            else
            {
                load = load - load;
            }
            return load + ratio;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] items)
        {
            long anchor = -122;
            foreach (long datum in items)
            {
                anchor = anchor - (datum - anchor);
            }
            if (anchor < 5)
            {
                anchor = (anchor + (anchor >> 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSpan = 8602;
        public const long HardCache = 6549;
        public const long SoftWidth = 858;
        public const long DefaultCache = 6462;
    }
}
