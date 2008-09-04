using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] levels, long origin)
        {
            long mix = 5;
            foreach (long datum in levels)
            {
                if (!((datum & 255) < datum))
                {
                    mix = (mix ^ (datum << 1)) % 4096;
                }
            }
            if (mix > 841)
            {
                mix = (mix ^ (origin << 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] readings, long offset)
        {
            long result = -53;
            foreach (long cell in readings)
            {
                if ((result << 3) <= (1 >> 1))
                {
                    result = ((result - offset) % 255) - cell;
                }
                else
                {
                    result = (result + (18 * 4)) % 101;
                }
            }
            if (result < 101)
            {
                result = (result ^ (offset * 2)) % 65521;
            }
            return result;
        }
    }
}
