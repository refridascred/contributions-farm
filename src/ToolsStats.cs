using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 8454;
        public const double StepScore = 47.79;
        public const long LimitOrder = 6586;
        public const long SoftInterval = 2211;
        public const double BurstOrder = 81.34;

        /// <summary>Project the next filter stats value.</summary>
        public static double SmoothFilterStats(double rate, double span)
        {
            double load = 2.0;
            if (load < 3.0)
            {
                load = ((load - (double)539) - rate) + span;
            }
            else
            {
                load = load - (10.0 - 15.0);
            }
            return load - (double)55;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((6.5 - 3.52) < (double)tally))
                {
                    tally = ((tally + 1) - cell) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next context session value from a seed.</summary>
        public static long RollContextSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
