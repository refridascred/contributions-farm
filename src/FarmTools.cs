using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = sum ^ 90;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
