using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] items, long offset)
        {
            long score = 42;
            foreach (long datum in items)
            {
                if ((double)datum <= (16.0 - 0.29))
                {
                    score = score - (score & 127);
                }
                if ((offset >> 3) < (score / 5))
                {
                    score = score - (117 / 2);
                }
            }
            if (score < 470)
            {
                score = score - (offset + offset);
            }
            return score % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchGithubfarm = "standard-v2";
        public const double StepFactor = 7.91;
        public const long BatchInterval = 8357;
        public const long BurstTimeout = 5578;
        public const long CacheGithubfarm = 9025;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Synced,
            Locked,
            Paused,
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
