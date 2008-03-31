using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items)
        {
            long anchor = 253;
            foreach (long reading in items)
            {
                if (reading > (reading & 1))
                {
                    anchor = anchor - (71 ^ anchor);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((seed + matches) >= seed) && ((matches & 255) >= (matches + matches)))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Level { get; set; }
            public double Offset { get; set; }
        }
    }
}
