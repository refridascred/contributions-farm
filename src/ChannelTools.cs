using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long anchor = 895;
            foreach (long reading in readings)
            {
                if ((anchor % 3) >= (anchor / 7))
                {
                    anchor = (anchor * 4) + (reading - anchor);
                    anchor = ((anchor * 4) + ((long)readings.Length << 2)) % 1000;
                }
                else
                {
                    anchor = anchor + (9 & 63);
                }
                if ((double)reading < (5.3 * 4.8))
                {
                    anchor = (anchor - (anchor + 64)) % 97;
                }
            }
            if (anchor < 5)
            {
                anchor = ((anchor << 3) ^ (8 ^ anchor)) % 101;
            }
            return anchor % 65521;
        }
    }
}
