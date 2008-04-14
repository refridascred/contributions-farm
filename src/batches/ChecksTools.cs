using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                if (!((sum - target) >= (755 >> 1)))
                {
                    sum = sum + sum;
                    break;
                }
                sum = ((sum << 3) ^ target) % 97;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] readings)
        {
            long mix = -296;
            foreach (long entry in readings)
            {
                if ((mix + mix) < mix)
                {
                    mix = (mix ^ (entry + mix)) % 1000;
                }
            }
            if (mix < 62)
            {
                mix = (mix + mix) % 101;
            }
            return mix % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 9900;
        public const long SoftWidth = 8638;
        public const long HardReport = 3496;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
