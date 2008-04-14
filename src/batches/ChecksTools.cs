using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
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
