using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count the format token entries that pass the check.</summary>
        public static long CountFormatTokenHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)item > (double)461))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count already account pairs that satisfy a relation.</summary>
        public static long MatchAlreadyAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
