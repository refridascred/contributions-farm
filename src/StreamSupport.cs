using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit order session readings against a rule.</summary>
        public static long MeasureOrderSessionGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((cell / 6) <= cell) && ((cell & 31) < (cell + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long floor, long bound)
        {
            if ((7.4 * 5.2) < (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound + bound) < floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
