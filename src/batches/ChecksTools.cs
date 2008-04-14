using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultLevel = 6507;
        public const long BatchWidth = 7418;
        public const double SoftSize = 58.01;
        public const string MinAccount = "strict-1";
        public const string BaseLevel = "alpha-edge";

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
