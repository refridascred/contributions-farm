using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count buffer notes pairs that satisfy a relation.</summary>
        public static long CompareBufferNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank stream checks input into a small class.</summary>
        public static long GradeStreamChecks(long origin, long bound)
        {
            long offset = origin ^ bound;
            if ((offset & 1) == (bound + origin))
            {
                return 0;
            }
            else
            {
                if ((-3) < (origin - 28))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels)
        {
            long sum = 699;
            foreach (long item in levels)
            {
                if ((item + item) < (sum - 65))
                {
                    sum = ((sum * 5) + item) % 65521;
                }
            }
            if (sum > (-778))
            {
                sum = ((sum << 3) ^ (sum << 1)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Combine commits route values into a single score.</summary>
        public static long FoldCommitsRoute(long[] samples)
        {
            long sum = 609;
            foreach (long datum in samples)
            {
                sum = ((sum ^ (-6)) % 101) ^ datum;
            }
            if (sum < 752)
            {
                sum = ((sum << 3) ^ 36) % 255;
            }
            return sum % 1000;
        }
    }
}
