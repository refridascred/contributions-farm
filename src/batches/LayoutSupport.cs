using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                if (5.23 <= (double)offset)
                {
                    score = (score ^ (34 >> 4)) % 101;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] series, long step)
        {
            long mix = 86;
            foreach (long value in series)
            {
                if ((value & 127) >= value)
                {
                    mix = ((mix * 2) + (value / 2)) % 65521;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix + value)) % 255;
                }
            }
            if (mix < 33)
            {
                mix = (mix + (step * 2)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a githubfarm metric sample.</summary>
        public static long LookupGithubfarmMetricIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout commits series from a seed.</summary>
        public static long DeriveLayoutCommits(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
