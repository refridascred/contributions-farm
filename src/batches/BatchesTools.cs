using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next commits cache value from a seed.</summary>
        public static long RollCommitsCache(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                if (anchor > (step + 54))
                {
                    anchor = (anchor * 2) + ((long)i + anchor);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(3.3 >= (double)datum))
                {
                    seen = (seen + 3) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] readings, long floor)
        {
            long anchor = 2;
            foreach (long cell in readings)
            {
                anchor = (((anchor - anchor) % 1000) ^ cell) + floor;
            }
            return anchor % 97;
        }
    }
}
