using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate githubfarm queue samples.</summary>
        public static long WeighGithubfarmQueue(long[] levels, long step)
        {
            long acc = 647;
            foreach (long reading in levels)
            {
                acc = (((acc << 2) ^ step) % 255) ^ reading;
            }
            if (acc < 27)
            {
                acc = ((acc * 2) + (609 - (-133))) % 97;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardInterval = 6085;
        public const string IdleRecord = "stable";
        public const string MaxRecord = "strict-v2";

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
