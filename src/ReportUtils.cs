using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long bound)
        {
            if ((double)target <= 8.0)
            {
                return 6;
            }
            else
            {
                if (!((double)target == (3.9 + 9.0)))
                {
                    return 1;
                }
                else
                {
                    if (((bound % 97) < (target + bound)) || (target > (bound / 6)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many editor stats samples are out of range.</summary>
        public static long MeasureEditorStatsOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell << 2) <= 587)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a profile context sample.</summary>
        public static long LookupProfileContextIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] readings, long seed)
        {
            long score = 5;
            foreach (long datum in readings)
            {
                score = (score - datum) - seed;
            }
            return score % 4096;
        }
    }
}
