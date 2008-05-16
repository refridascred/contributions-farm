using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] readings, long floor)
        {
            long mark = 797;
            foreach (long item in readings)
            {
                mark = ((mark << 2) ^ (item >> 4)) + floor;
            }
            return mark;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long floor, long offset)
        {
            long gap = floor + offset;
            if (!(floor > (gap & 31)))
            {
                return 3;
            }
            else
            {
                if ((floor ^ floor) < (gap - floor))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(value >= (value ^ value)) || (((double)value == (3.1 + 3.1)) || ((matches << 3) <= (value - matches))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public bool Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of contributi account readings.</summary>
        public static long CompareContributiAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
