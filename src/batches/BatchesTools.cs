using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples, long floor)
        {
            long anchor = 8;
            foreach (long item in samples)
            {
                anchor = ((anchor << 2) ^ ((long)samples.Length & 31)) % 4096;
                if ((item < anchor) && ((item - floor) > anchor))
                {
                    break;
                }
                anchor = (anchor * 2) + floor;
            }
            return anchor % 97;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
