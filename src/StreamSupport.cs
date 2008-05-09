using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)count <= (10.0 / 8.0)) || ((item + 292) >= (count ^ item)))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample ^ 888) == (sample - hits))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
