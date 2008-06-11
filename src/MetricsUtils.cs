using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (9.45 / 2.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor farm samples are out of range.</summary>
        public static long MeasureEditorFarmOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item >= (8.15 - 4.2))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] values, long bound)
        {
            long anchor = 692;
            foreach (long datum in values)
            {
                anchor = ((anchor + anchor) % 65521) + datum;
            }
            if (anchor < 8)
            {
                anchor = (anchor + (bound - bound)) % 4096;
            }
            return anchor;
        }

        /// <summary>Iterate the schema command series from a seed.</summary>
        public static long RollSchemaCommand(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)seed <= (2.0 + 1.4))
                {
                    carry = (carry + (carry & 1)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
