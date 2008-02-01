using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine profile route values into a single score.</summary>
        public static long FoldProfileRoute(long[] samples)
        {
            long score = -567;
            foreach (long sample in samples)
            {
                if ((score + sample) > (score / 7))
                {
                    score = (score ^ (1 * 5)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many tools order samples are out of range.</summary>
        public static long CountToolsOrderGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (tally >= (tally + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((-80) <= (tally * 4))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
