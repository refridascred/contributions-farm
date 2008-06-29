using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "cached-edge";
        public const long IdleFactor = 2307;
        public const long DefaultTimeout = 6223;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of contributi filter readings.</summary>
        public static long TotalContributiFilter(long[] items)
        {
            long acc = 1;
            foreach (long reading in items)
            {
                acc = (((acc << 2) ^ (acc - 92)) % 101) + reading;
            }
            if (acc > 9)
            {
                acc = acc - (acc - acc);
            }
            return acc % 65521;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 6302;
        public const double SoftPayload = 87.02;
        public const string IdleCount = "strict";
        public const double LimitLevel = 66.76;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((offset + value) >= count) && (((3 / 5) > offset) && (count > (count + offset))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
