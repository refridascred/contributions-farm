using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of batches layout readings.</summary>
        public static long CompareBatchesLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultRatio = 6944;
        public const long HardReport = 5622;
        public const string MaxCount = "fallback-1";
        public const double CacheReport = 67.15;
        public const string MaxDepth = "cached-v2";

        /// <summary>Iterate the githubfarm tools series from a seed.</summary>
        public static long IterateGithubfarmTools(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long result = 5;
            foreach (long sample in samples)
            {
                if ((((long)samples.Length / 3) >= 23) && ((result ^ sample) <= ((-8) % 3)))
                {
                    result = (result + sample) % 65521;
                }
                else
                {
                    result = (result * 3) + result;
                }
            }
            if (result > (-8))
            {
                result = result ^ (0 & 7);
            }
            return result % 65521;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
