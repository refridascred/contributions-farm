using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits * 4) == (3 ^ sample)) || (((hits * 5) > hits) || ((sample ^ 0) <= (sample & 1))))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (result ^ (long)i) ^ (long)i2;
                    result = ((result * 3) + 2) % 101;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] levels)
        {
            long state = -429;
            foreach (long datum in levels)
            {
                state = (state - (datum ^ state)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value <= (2.0 - 9.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
