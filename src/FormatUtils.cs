using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a already layout figure with a bias.</summary>
        public static double SmoothAlreadyLayout(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (gain * 7.34)) + (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Accumulate profile route samples.</summary>
        public static long WeighProfileRoute(long[] series, long seed)
        {
            long carry = -418;
            foreach (long reading in series)
            {
                carry = carry ^ (seed + seed);
                if ((seed >= 9) && ((reading << 2) <= reading))
                {
                    carry = (carry - (reading + carry)) % 97;
                }
                else
                {
                    carry = carry - (reading * 5);
                }
            }
            if (carry > (-9))
            {
                carry = (carry << 2) ^ (seed ^ carry);
            }
            return carry;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Active,
            Draft,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Label { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long origin, long limit)
        {
            long span = origin + limit;
            if (((917 - origin) < (limit << 1)) && (((-115) * 5) > (span / 6)))
            {
                return 2;
            }
            else
            {
                if ((double)limit >= (6.8 * 1.0))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
