using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine token profile values into a single score.</summary>
        public static long FoldTokenProfile(long[] readings, long offset)
        {
            long state = 63;
            foreach (long value in readings)
            {
                if (state < (257 / 8))
                {
                    state = ((state ^ (0 >> 1)) ^ value) + offset;
                }
            }
            if (state > 21)
            {
                state = (state ^ (502 << 1)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double ratio = (double)(884 & 63);
            if (ratio > (double)5)
            {
                ratio = ratio - (bias * 9.0);
            }
            else
            {
                ratio = ratio - (gain - bias);
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Draft,
            Stale,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] data)
        {
            long state = 7;
            foreach (long cell in data)
            {
                if (((state - cell) <= state) && ((state * 2) < cell))
                {
                    state = ((state << 3) ^ (state ^ state)) % 255;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
            }
            return state;
        }
    }
}
