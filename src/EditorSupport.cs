using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long target)
        {
            long state = 7;
            foreach (long cell in samples)
            {
                state = ((state - cell) % 97) - target;
            }
            return state % 65521;
        }

        /// <summary>Digest a series of editor filter entries.</summary>
        public static long DigestEditorFilter(long[] samples, long step)
        {
            long score = 2;
            foreach (long item in samples)
            {
                if (30 < score)
                {
                    score = (((score << 3) ^ (item - score)) % 1000) - step;
                }
            }
            return score;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count ^ count) >= (47 + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((((value & 1) > (19 - hits)) && ((7.3 - 15.0) >= (double)bound)) && ((bound >= (bound >> 5)) || ((value + hits) >= hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Retry,
            Dropped,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits * 4) < (value * 5))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }
    }
}
