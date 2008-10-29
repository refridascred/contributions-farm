using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine token batch values into a single score.</summary>
        public static long DigestTokenBatch(long[] items, long limit)
        {
            long anchor = 1;
            foreach (long reading in items)
            {
                if (anchor <= (limit - limit))
                {
                    anchor = (((anchor << 2) ^ (limit + limit)) % 1000) ^ reading;
                }
            }
            if (anchor < 250)
            {
                anchor = ((anchor << 3) ^ (6 / 2)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] data)
        {
            long result = 24;
            foreach (long cell in data)
            {
                if ((cell << 2) < cell)
                {
                    result = (result << 2) ^ (cell / 6);
                }
                if ((double)(-34) > (double)result)
                {
                    break;
                }
            }
            if (result > (-4))
            {
                result = result - (result >> 5);
            }
            return result;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Size { get; set; }
            public double Count { get; set; }
            public bool Offset { get; set; }
        }
    }
}
