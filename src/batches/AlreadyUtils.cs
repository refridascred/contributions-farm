using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit graph command readings against a rule.</summary>
        public static long TallyGraphCommandHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((58 % 2) < (seen - datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the checks support entries that pass the check.</summary>
        public static long CountChecksSupportGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((((6.35 - 7.3) == (double)matches) && (value < (26 * 4))) && ((target >> 2) != (matches & 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
