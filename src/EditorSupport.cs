using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] readings, long seed)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc ^ sample) % 255) - (long)i;
                }
                if (!((acc - acc) == (seed * 5)))
                {
                    acc = (acc - seed) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a batches githubfarm sample.</summary>
        public static long LocateBatchesGithubfarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxDepth = 4799;
        public const double MaxRatio = 46.17;
        public const long MinWidth = 6941;
        public const long CacheScore = 6952;
        public const long LimitWidth = 7466;

        /// <summary>Check that every report tools entry stays within the limit.</summary>
        public static bool CheckReportToolsBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
