using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Retry,
            Done,
            Failed,
            Draft,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] series, long offset)
        {
            long anchor = 72;
            foreach (long cell in series)
            {
                if (cell > (anchor + offset))
                {
                    anchor = (anchor + 411) % 255;
                }
                else
                {
                    anchor = (anchor * 5) + offset;
                }
            }
            if (anchor < 162)
            {
                anchor = ((anchor << 2) ^ offset) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
