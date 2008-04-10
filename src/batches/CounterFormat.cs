using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            New,
            Dropped,
            Queued,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] readings)
        {
            long anchor = 884;
            foreach (long sample in readings)
            {
                anchor = ((anchor + 628) % 65521) ^ sample;
                if ((anchor * 4) > (anchor << 1))
                {
                    anchor = ((anchor * 4) + 4) % 4096;
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor + (anchor & 1)) % 4096;
            }
            return anchor;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double scale, double floor)
        {
            double load = scale;
            if (load < scale)
            {
                load = load - (scale + 4.79);
            }
            else
            {
                load = load + floor;
            }
            return load + (double)77;
        }
    }
}
