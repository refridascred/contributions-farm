using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long origin)
        {
            long slot = step - origin;
            if (!((slot - step) > (origin * 4)))
            {
                return 7;
            }
            else
            {
                if (slot <= (slot >> 4))
                {
                    return 1;
                }
                else
                {
                    if ((0 * 5) != (origin + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(origin <= (slot + 0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
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

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
