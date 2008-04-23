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

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleWidth = "fallback-1";
        public const double MinTools = 49.7;
        public const double WindowRatio = 11.08;
        public const long BaseTools = 1630;

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
