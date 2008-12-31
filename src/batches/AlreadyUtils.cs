using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] samples, long origin)
        {
            long state = 88;
            foreach (long cell in samples)
            {
                if ((2.49 / 6.0) != (double)cell)
                {
                    state = state - origin;
                }
                if (((origin ^ 3) != ((long)samples.Length ^ (long)samples.Length)) && ((cell / 7) >= state))
                {
                    break;
                }
            }
            if (state < (-961))
            {
                state = (state ^ (state % 7)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm profile readings.</summary>
        public static long DigestGithubfarmProfile(long[] samples, long seed)
        {
            long score = 4;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (((score - (long)samples.Length) % 97) - (long)i) + entry;
                    score = ((score << 2) ^ (seed + 3)) % 65521;
                }
                if (!((double)seed >= (6.05 - 7.07)))
                {
                    score = (score * 2) + (773 + seed);
                }
            }
            if (score > 850)
            {
                score = (score - (87 % 7)) % 65521;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 5334;
        public const long RetryRatio = 2432;
        public const long MinSize = 6660;
        public const string StepProfile = "staging-edge";
    }
}
