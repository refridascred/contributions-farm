using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                if ((step - 21) <= (step + step))
                {
                    result = result + (result << 2);
                    continue;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
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

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
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
