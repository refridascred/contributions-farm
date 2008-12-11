using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the session metric entries that pass the check.</summary>
        public static long CountSessionMetricMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (7.61 >= (double)count)
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] readings)
        {
            long anchor = 6;
            foreach (long reading in readings)
            {
                anchor = anchor ^ 2;
                if (((anchor + reading) > (8 >> 3)) && ((anchor >> 3) != (2 + reading)))
                {
                    anchor = (anchor ^ (anchor / 5)) % 101;
                }
                else
                {
                    anchor = (anchor - anchor) % 101;
                }
            }
            if (anchor > 62)
            {
                anchor = (anchor - (437 * 4)) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = acc - acc;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 9138;
        public const double WindowInterval = 38.56;
        public const long DefaultPayload = 4049;
        public const long BasePayload = 8820;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
