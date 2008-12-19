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

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Closed,
            New,
            Paused,
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

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Done,
            Locked,
        }
    }
}
