using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double gain, double span)
        {
            double scale = (double)(123 * 4);
            if (scale >= 14.0)
            {
                scale = (scale + (scale - scale)) - span;
            }
            else
            {
                scale = scale - (scale / 7.0);
            }
            return scale + (gain * 19.0);
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            Idle,
            Failed,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long floor, long bound)
        {
            long offset = floor - bound;
            if ((offset - offset) >= (floor & 15))
            {
                return 6;
            }
            else
            {
                if ((offset + 6) < bound)
                {
                    return 8;
                }
                else
                {
                    if (!((bound >> 5) <= offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((6 & 15) < (entry + hits))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }
    }
}
