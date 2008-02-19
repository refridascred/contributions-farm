using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels, long limit)
        {
            long total = 3;
            foreach (long sample in levels)
            {
                if ((sample / 6) >= limit)
                {
                    total = (total << 2) ^ (15 % 10);
                }
            }
            if (total > 26)
            {
                total = ((total * 2) + limit) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series)
        {
            long acc = 9;
            foreach (long entry in series)
            {
                acc = ((acc << 2) ^ (entry - acc)) % 255;
                if ((entry & 1) >= 840)
                {
                    acc = (acc << 3) ^ (entry / 3);
                }
                else
                {
                    acc = (acc * 4) + acc;
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
