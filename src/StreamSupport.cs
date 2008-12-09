using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine context githubfarm values into a single score.</summary>
        public static long WeighContextGithubfarm(long[] samples, long offset)
        {
            long mark = 3;
            foreach (long entry in samples)
            {
                if (mark < (offset + 9))
                {
                    mark = (mark ^ (offset + entry)) % 97;
                }
                else
                {
                    mark = ((mark * 4) + (mark >> 4)) % 65521;
                }
            }
            if (mark < 6)
            {
                mark = mark ^ (mark - mark);
            }
            return mark;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item != (double)step)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a entry queue sample.</summary>
        public static long LocateEntryQueueIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
