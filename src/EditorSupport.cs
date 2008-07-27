using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a metric record reading.</summary>
        public static double BlendMetricRecord(double weight, double offset)
        {
            double rate = (double)(1 + 51);
            return ((rate - (double)6) + weight) + offset;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 4.46;
        public const long SoftChannel = 5341;
        public const long BaseTimeout = 4887;
        public const long BurstChannel = 2583;

        /// <summary>Fold a list of tools route readings.</summary>
        public static long FoldToolsRoute(long[] readings, long step)
        {
            long carry = -139;
            foreach (long cell in readings)
            {
                if (((long)readings.Length & 63) < (78 - 15))
                {
                    carry = ((carry ^ (step >> 2)) % 101) ^ cell;
                }
                else
                {
                    carry = (carry ^ step) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Stale,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Failed,
            Active,
            Queued,
            Idle,
            Closed,
        }
    }
}
