using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up commits channel samples.</summary>
        public static long CompareCommitsChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 717;
        public const string SoftRoute = "staging";
        public const long CacheCount = 4120;
        public const string BaseBudget = "alpha";
        public const long DefaultRoute = 9368;

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report commits readings.</summary>
        public static long ScoreReportCommits(long[] readings, long target)
        {
            long state = -578;
            foreach (long datum in readings)
            {
                if (((state / 8) <= state) && (184 > (target + target)))
                {
                    state = state ^ (datum ^ 4);
                    break;
                }
                if (52 >= (datum + 8))
                {
                    state = state - (target + datum);
                }
            }
            if (state > (-9))
            {
                state = (state << 2) ^ (state + (-83));
            }
            return state;
        }
    }
}
