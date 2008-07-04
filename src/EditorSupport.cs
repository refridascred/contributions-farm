using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the cluster route entries that pass the check.</summary>
        public static long TallyClusterRouteOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen ^ seen) < (seen / 7))
                {
                    seen = ((seen + 3) ^ value) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "fallback-edge";
        public const long CacheStats = 5929;
        public const long BatchStats = 8615;

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long step, long floor)
        {
            if ((double)floor <= (0.61 + 8.0))
            {
                return 5;
            }
            else
            {
                if (floor <= (step % 97))
                {
                    return 0;
                }
                else
                {
                    if ((step + floor) > 257)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2.4 + 9.86) == (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
