using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum % 2) > (count ^ datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] data)
        {
            long total = 5;
            foreach (long datum in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((total + total) % 255) ^ (long)i;
                }
                if (!((total / 5) > (total + total)))
                {
                    total = (total + (datum - 769)) % 97;
                }
                else
                {
                    total = (total ^ (-5)) % 97;
                }
            }
            if (total < 9)
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Draft,
            Stale,
            Dropped,
            Closed,
            Synced,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)8 >= (double)hits)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 6552;
        public const double BatchScore = 41.88;
        public const string MaxRecord = "staging-edge";
        public const long RetryInterval = 7831;
    }
}
