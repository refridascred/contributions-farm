using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen <= (datum << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long limit)
        {
            if (((offset / 5) >= (limit % 7)) || (offset >= (limit * 5)))
            {
                return 6;
            }
            else
            {
                if ((limit - 65) < offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset < (offset ^ offset)) || ((limit << 3) > (limit << 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
