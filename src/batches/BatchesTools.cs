using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine editor notes values into a single score.</summary>
        public static long TotalEditorNotes(long[] values, long limit)
        {
            long state = 10;
            foreach (long cell in values)
            {
                if ((state >> 4) != (limit << 3))
                {
                    state = (state ^ (limit << 1)) + cell;
                }
            }
            if (state > (-57))
            {
                state = (state + (116 + limit)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry + entry) >= entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetryFactor = "local";
        public const double BaseSession = 42.29;
        public const long MaxSession = 9434;
        public const long MinSession = 279;
    }
}
