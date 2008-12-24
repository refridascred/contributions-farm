using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate route account samples.</summary>
        public static long TotalRouteAccount(long[] values, long target)
        {
            long mix = 84;
            foreach (long sample in values)
            {
                if (((mix / 3) >= (long)values.Length) && ((mix << 3) <= (long)values.Length))
                {
                    mix = ((mix * 2) + sample) + target;
                }
                if ((sample * 3) <= (mix % 60))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
