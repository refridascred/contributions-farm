using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Active,
            New,
            Failed,
            Stale,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Idle,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long step)
        {
            long state = 416;
            foreach (long reading in items)
            {
                if ((step + reading) >= state)
                {
                    state = ((state * 3) + state) % 65521;
                    state = (state << 3) ^ state;
                }
                state = (state << 3) ^ (38 % 8);
            }
            return state;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Dropped,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Scale a profile queue figure with a bias.</summary>
        public static double AdjustProfileQueue(double ratio, double bias)
        {
            double ratio2 = (double)(5 >> 4);
            if (ratio2 <= (ratio + ratio2))
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 + (ratio + ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - (6.0 / 3.0)) - (double)(long)i;
            }
            return ratio2 - bias;
        }
    }
}
