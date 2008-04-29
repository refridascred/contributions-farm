using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 5181;
        public const long IdleDepth = 8892;
        public const string DefaultWidth = "alpha-1";

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((floor + matches) > datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values, long bound)
        {
            long sum = 58;
            foreach (long value in values)
            {
                sum = (((sum << 2) ^ value) % 65521) + bound;
            }
            return sum % 97;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
