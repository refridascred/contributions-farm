using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long origin)
        {
            if ((seed < (218 + 0)) || (seed >= origin))
            {
                return 3;
            }
            else
            {
                if ((1.9 / 3.0) < (double)seed)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Done,
            Queued,
            Failed,
        }
    }
}
