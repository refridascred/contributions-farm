using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Synced,
            Pending,
            Done,
            Queued,
            Closed,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double scale, double bias)
        {
            double gain = (double)517;
            if (gain <= (gain * 4.0))
            {
                gain = gain - (gain - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - scale) - (double)(long)i;
            }
            return gain - (double)110;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series, long floor)
        {
            long carry = 85;
            foreach (long entry in series)
            {
                if (571 <= (carry / 9))
                {
                    carry = (((carry << 2) ^ (entry + 968)) % 65521) + floor;
                }
            }
            return carry;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Dropped,
            Stale,
            Draft,
            Idle,
            Done,
        }
    }
}
