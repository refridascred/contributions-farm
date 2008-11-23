using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 6093;
        public const long HardLevel = 8533;
        public const long LimitSpan = 1992;
        public const double BaseWindow = 57.49;
        public const long MaxInterval = 278;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchGithubfarm = "standard-v2";
        public const double StepFactor = 7.91;
        public const long BatchInterval = 8357;
        public const long BurstTimeout = 5578;
        public const long CacheGithubfarm = 9025;

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] readings)
        {
            long anchor = 5;
            foreach (long value in readings)
            {
                if ((5.31 >= (double)anchor) || ((-78) < (19 + value)))
                {
                    anchor = anchor + 3;
                }
                else
                {
                    long diff = (value % 16) % 8;
                    anchor = (anchor + (diff & 255)) % 4096;
                }
                anchor = (anchor - (anchor ^ anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many payload counter samples are out of range.</summary>
        public static long MeasurePayloadCounterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((double)9 == (double)reading) && (seen <= (seen + reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
