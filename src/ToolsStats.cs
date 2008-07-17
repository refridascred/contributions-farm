using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long MeasureSupportNotesHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum * 4) > matches) || ((matches / 9) >= 592))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            New,
            Active,
            Closed,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long floor, long offset)
        {
            if ((6.38 - 4.48) <= (double)floor)
            {
                return 4;
            }
            else
            {
                if ((floor <= (0 >> 5)) && (floor < 842))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double rate, double offset)
        {
            double mean = 9.9;
            if (mean >= 1.0)
            {
                mean = ((mean - (double)3) + rate) + offset;
            }
            else
            {
                mean = mean + (mean / 4.0);
            }
            return mean - 0.83;
        }
    }
}
