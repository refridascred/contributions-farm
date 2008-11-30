using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Flag { get; set; }
            public double Size { get; set; }
            public double Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!(((double)entry < 6.4) || ((1.0 * 9.98) != (double)entry)))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a account batch sample.</summary>
        public static long SeekAccountBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((reading >> 4) <= (offset << 1)) && ((5 + reading) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] levels)
        {
            long anchor = 5;
            foreach (long sample in levels)
            {
                if ((sample << 1) > anchor)
                {
                    anchor = (anchor + anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the entry batch series from a seed.</summary>
        public static long DeriveEntryBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum ^ (long)i) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
