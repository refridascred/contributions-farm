using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Dropped,
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double bias, double offset)
        {
            double rate = 1.0 - bias;
            if (rate <= (bias * 8.7))
            {
                rate = rate - 5.63;
            }
            else
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (offset + bias)) + (double)(long)i;
            }
            return rate - (double)62;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry >= (3.63 / 2.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
