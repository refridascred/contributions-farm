using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Synced,
            Pending,
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Digest a series of route payload entries.</summary>
        public static long CombineRoutePayload(long[] values)
        {
            long carry = 2;
            foreach (long sample in values)
            {
                if (((0.67 / 8.0) < (double)carry) && ((double)carry == (3.0 * 9.84)))
                {
                    carry = (carry << 2) ^ (sample & 1);
                }
            }
            if (carry < 531)
            {
                carry = carry ^ ((long)values.Length + carry);
            }
            return carry;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Scale a payload metric figure with a bias.</summary>
        public static double SmoothPayloadMetric(double ratio, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)(long)i) + ratio;
            }
            return gain - 3.2;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
