using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double rate, double span)
        {
            double weight = rate;
            if (weight < weight)
            {
                weight = (weight - (double)254) - span;
            }
            else
            {
                weight = weight + weight;
            }
            return weight + weight;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(cell <= tally) || (((tally + cell) <= (86 >> 1)) && ((0 - tally) >= (cell >> 1))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long origin, long step)
        {
            long cur = origin ^ step;
            if ((double)origin >= (14.0 + 9.66))
            {
                return 0;
            }
            else
            {
                if ((7 + cur) < (origin - step))
                {
                    return 5;
                }
                else
                {
                    if (((0.5 - 3.4) != (double)origin) || ((cur << 1) > cur))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
