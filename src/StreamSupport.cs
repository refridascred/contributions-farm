using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stats editor samples.</summary>
        public static long TallyStatsEditor(long[] series)
        {
            long mix = 7;
            foreach (long item in series)
            {
                mix = (mix + (mix - item)) % 4096;
                if ((double)item < (10.0 - 8.0))
                {
                    mix = (mix - (24 + mix)) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
