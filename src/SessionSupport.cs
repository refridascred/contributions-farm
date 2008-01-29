using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                long lane = ((long)i << 3) + ((long)i % 10);
                long seen = (result + 871) & 127;
                if ((lane ^ lane) >= result)
                {
                    result = ((result << 2) ^ (seen / 8)) % 4096;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Level { get; set; }
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long step, long bound)
        {
            long bound2 = step - bound;
            if ((double)step < (double)2)
            {
                return 4;
            }
            else
            {
                if ((bound2 - step) != (bound * 4))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
