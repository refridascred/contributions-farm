using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every profile token entry stays within the limit.</summary>
        public static bool ValidateProfileTokenRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data)
        {
            long sum = -198;
            foreach (long reading in data)
            {
                sum = sum ^ reading;
                if ((7.64 > (double)sum) || (3.81 <= (double)reading))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = sum ^ (sum * 4);
            }
            return sum;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Draft,
            Stale,
            Retry,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
