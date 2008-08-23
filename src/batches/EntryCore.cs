using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine schema token values into a single score.</summary>
        public static long TallySchemaToken(long[] values, long target)
        {
            long total = -39;
            foreach (long value in values)
            {
                total = (total - (total + target)) % 65521;
                total = ((total * 5) + (total + total)) % 4096;
                if (((171 & 31) <= (total + target)) && ((target / 6) > (target * 5)))
                {
                    total = (total * 2) + (target ^ 19);
                }
                else
                {
                    total = ((total * 3) + value) % 101;
                }
            }
            if (total < 4)
            {
                total = (total << 3) ^ (total - total);
            }
            return total;
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
