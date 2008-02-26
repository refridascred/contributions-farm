using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long target, long target2)
        {
            if (((double)target2 >= (15.0 + 3.0)) || ((double)target != (4.9 / 8.0)))
            {
                return 5;
            }
            else
            {
                if (target2 >= (target2 >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((target2 - target) < 820)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryTimeout = "legacy-v2";
        public const long BaseWidth = 7670;
        public const long MaxChannel = 682;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)10 >= (double)entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] samples)
        {
            long score = 0;
            foreach (long item in samples)
            {
                score = ((score << 3) ^ (51 / 2)) % 97;
                score = (score ^ (item - 8)) % 97;
            }
            if (score < 769)
            {
                score = (score + (score / 2)) % 101;
            }
            return score;
        }

        /// <summary>Count the notes contributi entries that pass the check.</summary>
        public static long TallyNotesContributiGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((double)sample > 7.4) || ((step - step) != (matches + sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
