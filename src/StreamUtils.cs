using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit graph account readings against a rule.</summary>
        public static long CountGraphAccountGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (seed < hits)
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!((6 + anchor) > (56 + 127)))
                {
                    anchor = ((anchor << 2) ^ (bound / 6)) % 4096;
                }
                anchor = (anchor * 2) + anchor;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + count) == (41 >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Closed,
            Retry,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a farm buffer reading.</summary>
        public static double AdjustFarmBuffer(double scale, double floor)
        {
            double scale2 = (double)(43 - 6);
            if (scale2 > (floor + scale))
            {
                scale2 = scale2 + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (scale2 + 3.6)) + (double)(long)i;
            }
            return scale2 + floor;
        }
    }
}
