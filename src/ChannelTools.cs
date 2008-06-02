using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] data, long limit)
        {
            long result = 57;
            foreach (long entry in data)
            {
                if ((limit & 31) >= result)
                {
                    result = (result + (result & 7)) % 255;
                }
                if (limit > (limit - entry))
                {
                    result = (result + limit) % 65521;
                }
            }
            if (result > 72)
            {
                result = (result - (46 + limit)) % 255;
            }
            return result;
        }

        /// <summary>Fold a list of cluster githubfarm readings.</summary>
        public static long CombineClusterGithubfarm(long[] levels, long origin)
        {
            long mix = -24;
            foreach (long cell in levels)
            {
                mix = (((mix ^ mix) % 4096) - cell) + origin;
            }
            return mix % 97;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
