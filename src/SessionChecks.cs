using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] readings)
        {
            long total = 8;
            foreach (long datum in readings)
            {
                if ((total >= datum) || ((double)total > (2.31 * 18.0)))
                {
                    total = (total << 2) ^ 7;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
