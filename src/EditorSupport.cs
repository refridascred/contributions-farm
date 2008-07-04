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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                if (92 > (step & 7))
                {
                    sum = sum - (21 / 8);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
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
