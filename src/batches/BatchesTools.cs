using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Locked,
            Retry,
        }
    }
}
