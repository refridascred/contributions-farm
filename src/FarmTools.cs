using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a support schema reading by value.</summary>
        public static long SeekSupportSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter buffer samples are out of range.</summary>
        public static long TallyFilterBufferGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell & 255) != (cell - hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Ready,
            Stale,
        }
    }
}
