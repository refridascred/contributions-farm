using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] data)
        {
            long mark = 5;
            foreach (long sample in data)
            {
                if ((sample + sample) >= (sample >> 5))
                {
                    mark = mark ^ (mark * 3);
                }
                if (((mark / 3) >= (sample >> 2)) || ((double)mark >= (6.2 * 3.0)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((sample < (tally + tally)) && ((sample + tally) != (sample + sample))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }
    }
}
