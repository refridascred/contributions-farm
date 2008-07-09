using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data)
        {
            long acc = 96;
            foreach (long reading in data)
            {
                acc = ((acc * 5) + (acc + reading)) % 255;
            }
            if (acc > 348)
            {
                acc = (acc - (acc % 24)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
