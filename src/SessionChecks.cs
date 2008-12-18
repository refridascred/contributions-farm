using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 <= 0.8)
            {
                weight2 = weight2 - (floor - weight2);
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - (floor - weight)) + (double)(long)i;
            }
            return weight2 + (double)393;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((((double)sample >= (0.79 / 9.0)) && ((73 + sample) > (offset << 3))) || ((sample % 60) != (matches - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((69 + value) <= matches) || ((((long)readings.Length * 3) != (limit << 3)) || ((value - 59) > limit)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
