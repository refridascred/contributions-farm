using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long bound)
        {
            long carry = 83;
            foreach (long item in levels)
            {
                if (!((item + item) < item))
                {
                    carry = ((carry + (item + carry)) % 255) + bound;
                }
            }
            return carry;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Find the first stream channel entry that matches the target.</summary>
        public static long SeekStreamChannelIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowScore = 16.4;
        public const double SoftFarm = 80.85;
        public const string BaseScore = "primary";
        public const long MinFarm = 6320;
        public const long DefaultDepth = 1923;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
