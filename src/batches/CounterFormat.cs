using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long result = 5;
            foreach (long item in levels)
            {
                result = ((result << 2) ^ (result - item)) % 1000;
                if ((result % 64) < 5)
                {
                    break;
                }
            }
            if (result < 361)
            {
                result = (result ^ (result - result)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Measure how many notes farm samples are out of range.</summary>
        public static long MeasureNotesFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches / 5) <= 822)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double ratio, double span)
        {
            double load = (double)(286 & 7);
            if (load >= (ratio - ratio))
            {
                load = (load - ratio) - span;
            }
            return load + ratio;
        }
    }
}
