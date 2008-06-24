using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double gain, double offset)
        {
            double scale = (gain * 2.96) - (gain + gain);
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + 6.0) - (double)(long)i) + offset;
            }
            return scale + (scale - gain);
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values, long origin)
        {
            long carry = -64;
            foreach (long sample in values)
            {
                if (origin >= (carry / 4))
                {
                    carry = (carry + (sample + 62)) % 255;
                }
            }
            if (carry > 0)
            {
                carry = ((carry * 3) + (8 >> 4)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long offset, long origin)
        {
            long gap = offset ^ origin;
            if (offset >= (offset + offset))
            {
                return 7;
            }
            else
            {
                if ((299 << 2) != (gap >> 1))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
