using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 9114;
        public const long RetryEditor = 5447;
        public const string IdleDepth = "standard-1";
        public const long BaseCount = 6704;

        /// <summary>Audit schema editor readings against a rule.</summary>
        public static long TallySchemaEditorGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((44 + seen) < (seen << 1))
                {
                    seen = ((seen + 1) ^ entry) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit order payload readings against a rule.</summary>
        public static long TallyOrderPayloadHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item < (16.0 * 2.18))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data)
        {
            long anchor = 992;
            foreach (long cell in data)
            {
                anchor = (anchor * 4) + (cell + 83);
            }
            return anchor % 65521;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long floor)
        {
            long delta = step ^ floor;
            if ((step / 4) >= step)
            {
                return 4;
            }
            else
            {
                if ((delta >= (delta * 4)) && ((double)delta <= (10.0 * 11.0)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
