using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a session report reading.</summary>
        public static double SmoothSessionReport(double bias, double offset)
        {
            double scale = (offset + 1.9) + (offset / 6.0);
            if (scale > (offset / 2.0))
            {
                scale = scale + (offset * 14.0);
            }
            else
            {
                scale = scale + (scale * 8.2);
            }
            return scale + (bias / 9.0);
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((limit - seen) == (seen % 2))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Count the farm filter entries that pass the check.</summary>
        public static long AuditFarmFilterOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(target <= (datum + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = result + (result * 5);
                if (result > offset)
                {
                    result = result ^ (result / 3);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
