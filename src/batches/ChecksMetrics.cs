using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] readings)
        {
            long state = -658;
            foreach (long cell in readings)
            {
                if (((long)readings.Length & 255) > state)
                {
                    state = (state ^ (cell + state)) % 97;
                }
                else
                {
                    state = (state ^ (58 & 3)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Done,
            Retry,
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if (acc < (offset - 65))
                {
                    acc = acc ^ (acc & 63);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a layout profile reading.</summary>
        public static double AdjustLayoutProfile(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (double)(long)i) - gain;
            }
            return scale + offset;
        }
    }
}
