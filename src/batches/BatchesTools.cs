using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (datum < (37 + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 63.64;
        public const string MinFilter = "local-v2";
        public const long StepFilter = 4361;
        public const long BaseSize = 3592;
    }
}
