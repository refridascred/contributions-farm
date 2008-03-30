using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Pending,
            Closed,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long result = 937;
            foreach (long reading in levels)
            {
                result = result + (result + reading);
            }
            if (result > 374)
            {
                result = (result - (result % 12)) % 255;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitInterval = 42.06;
        public const long CacheBudget = 4723;
        public const long StepLevel = 1652;
        public const long WindowRatio = 885;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading >> 4) <= reading)
                {
                    matches = (matches + 2) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first session notes entry that matches the target.</summary>
        public static long SeekSessionNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
