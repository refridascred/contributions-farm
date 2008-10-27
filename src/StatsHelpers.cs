using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Region { get; set; } = "";
            public double Size { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit & 255) <= anchor)
                {
                    anchor = anchor + ((long)i * 2);
                }
                else
                {
                    anchor = (anchor + ((long)i + anchor)) % 65521;
                }
                if (!((limit - anchor) <= (limit % 97)))
                {
                    continue;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (82 / 7)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((seen << 1) != (sample - seen)) || ((80 * 4) >= sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 5757;
        public const string DefaultSession = "legacy-v2";
        public const double MinWidth = 28.63;
        public const long LimitScore = 9246;

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long origin, long step)
        {
            if (!(5.3 > (double)step))
            {
                return 3;
            }
            else
            {
                if ((step * 5) >= origin)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
