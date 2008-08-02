using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!(cell >= (cell * 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value <= (1.66 - 4.94))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }
    }
}
