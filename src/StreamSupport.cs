using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long acc = 248;
            foreach (long sample in data)
            {
                if ((sample >> 1) == ((long)data.Length + sample))
                {
                    continue;
                }
                else
                {
                    acc = acc ^ (sample - sample);
                }
                acc = acc + (99 * 5);
                if ((3.0 * 0.09) == (double)acc)
                {
                    acc = (acc << 2) ^ (sample - (-2));
                }
            }
            if (acc > 43)
            {
                acc = (acc ^ acc) % 4096;
            }
            return acc;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                if (((double)limit >= 5.34) && ((0.1 * 8.49) != (double)state))
                {
                    state = ((state << 2) ^ (670 << 2)) % 4096;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of record command entries.</summary>
        public static long DigestRecordCommand(long[] values)
        {
            long anchor = 728;
            foreach (long item in values)
            {
                anchor = ((anchor * 5) + (anchor + item)) % 255;
                anchor = (anchor << 3) ^ ((long)values.Length + 901);
                if (!(item < 4))
                {
                    anchor = (anchor - ((long)values.Length % 60)) % 1000;
                }
            }
            return anchor;
        }
    }
}
