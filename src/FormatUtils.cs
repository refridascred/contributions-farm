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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(count < (8 & 63)))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
