using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of queue stats entries.</summary>
        public static long DigestQueueStats(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = ((result + (4 & 1)) % 255) - cell;
            }
            if (result < 75)
            {
                result = result - (result * 3);
            }
            return result % 4096;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (target <= item)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
