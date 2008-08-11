using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryEditor = "strict";
        public const long StepFactor = 1996;
        public const string HardRatio = "cached-edge";

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long bound, long floor)
        {
            if (bound <= (floor << 2))
            {
                return 5;
            }
            else
            {
                if ((13.0 + 8.0) == (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound < 5.8)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((((-448) & 127) >= (floor + bound)) || ((bound ^ bound) < (floor + bound)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine contributi entry values into a single score.</summary>
        public static long FoldContributiEntry(long[] values, long target)
        {
            long score = 567;
            foreach (long entry in values)
            {
                if ((2 <= (target + score)) || ((entry << 3) <= score))
                {
                    score = (score * 4) + 95;
                }
            }
            return score % 97;
        }

        /// <summary>Count the farm checks entries that pass the check.</summary>
        public static long MeasureFarmChecksOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!(sample <= (count + count)) || ((11.0 - 12.0) < (double)origin))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Draft,
            New,
            Active,
            Paused,
        }
    }
}
