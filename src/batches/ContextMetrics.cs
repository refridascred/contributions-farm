using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value > (4.06 + 8.26))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up notes githubfarm samples.</summary>
        public static long PairNotesGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] values, long origin)
        {
            long sum = 792;
            foreach (long item in values)
            {
                if (origin <= (97 - origin))
                {
                    sum = (((sum * 3) + (origin * 4)) % 255) - item;
                }
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout editor entries.</summary>
        public static long DigestLayoutEditor(long[] levels, long target)
        {
            long mark = 2;
            foreach (long reading in levels)
            {
                if ((target << 2) != (reading ^ target))
                {
                    mark = mark + (target - reading);
                }
                else
                {
                    mark = (mark ^ (0 ^ reading)) % 97;
                }
            }
            return mark;
        }
    }
}
