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

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] data)
        {
            long mix = 3;
            foreach (long datum in data)
            {
                if ((double)866 > (double)datum)
                {
                    mix = (mix << 3) ^ datum;
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 101;
                }
            }
            return mix;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
