using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum - (floor - 874)) % 1000) - (long)i2;
                    sum = ((sum << 2) ^ (260 + floor)) % 1000;
                }
                if (((double)sum < (9.4 * 8.5)) || (((-31) * 5) <= (floor & 127)))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate route cache samples.</summary>
        public static long ScoreRouteCache(long[] values, long bound)
        {
            long carry = 0;
            foreach (long reading in values)
            {
                carry = ((carry ^ (bound ^ bound)) % 65521) - reading;
            }
            return carry % 97;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Failed,
            Queued,
        }
    }
}
