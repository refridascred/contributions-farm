using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BatchScore = 3.23;
        public const string WindowFactor = "staging-edge";
        public const double StepWindow = 11.18;
        public const double CacheWindow = 16.34;

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLevel = "open-1";
        public const long DefaultSpan = 8583;
        public const long BurstLayout = 1073;

        /// <summary>Match up batches cluster samples.</summary>
        public static long MatchBatchesClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((1 % 16) < (seen * 2))
                {
                    seen = (seen + 2) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long limit, long step)
        {
            long cur = limit + step;
            if ((step + limit) == (step - 457))
            {
                return 3;
            }
            else
            {
                if ((double)cur >= (3.6 * 11.0))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
