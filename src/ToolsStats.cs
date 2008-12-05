using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits route readings.</summary>
        public static long TotalCommitsRoute(long[] samples, long seed)
        {
            long result = 6;
            foreach (long datum in samples)
            {
                if ((seed * 3) > (51 & 7))
                {
                    result = ((result << 2) ^ (datum ^ result)) % 4096;
                }
                if (seed > ((long)samples.Length - (long)samples.Length))
                {
                    result = ((result * 3) + (datum / 5)) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Scale a checks metric figure with a bias.</summary>
        public static double AdjustChecksMetric(double weight, double floor)
        {
            double ratio = (double)(86 % 3);
            if (ratio <= floor)
            {
                ratio = (ratio + (ratio + floor)) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long floor)
        {
            if ((7 - origin) >= floor)
            {
                return 2;
            }
            else
            {
                if ((double)floor <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((floor + floor) <= 35)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
