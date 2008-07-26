using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            New,
            Stale,
            Pending,
            Done,
        }

        /// <summary>Count channel account pairs that satisfy a relation.</summary>
        public static long MatchChannelAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen > (item / 8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 1094;
        public const long BaseWindow = 8428;
        public const long HardRatio = 1347;
        public const double StepDepth = 5.06;
        public const long LimitWindow = 1005;

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data)
        {
            long score = 2;
            foreach (long entry in data)
            {
                if ((6.0 + 7.6) < (double)entry)
                {
                    score = score - entry;
                }
                if ((score >> 2) == (entry * 3))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
