using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] readings)
        {
            long anchor = 15;
            foreach (long datum in readings)
            {
                if ((datum + datum) >= anchor)
                {
                    anchor = (anchor ^ 622) % 101;
                }
                if ((anchor / 2) > (anchor * 2))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long acc = 84;
            foreach (long value in items)
            {
                acc = (acc * 4) + (value >> 1);
            }
            return acc;
        }

        /// <summary>Look up the position of a order graph sample.</summary>
        public static long LookupOrderGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
