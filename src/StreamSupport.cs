using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((7.5 + 2.0) < (double)acc)
                {
                    acc = ((acc * 3) + (origin % 97)) % 1000;
                    acc = acc + (63 - origin);
                }
                else
                {
                    acc = ((acc << 2) ^ (acc % 3)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
