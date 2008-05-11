using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(66 < (offset + offset)) && (((long)values.Length >> 1) < offset))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 7317;
        public const double StepTimeout = 88.57;
        public const long IdleInterval = 5519;
        public const long StepBudget = 7786;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((double)reading == (double)8) && ((reading - 69) <= (reading + reading)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Draft,
            Done,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Draft,
            Retry,
        }
    }
}
