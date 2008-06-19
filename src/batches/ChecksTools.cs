using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            Queued,
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((((-8) + count) == (count ^ count)) && ((5 + count) == (441 & 127))) || ((count >> 4) <= value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > (double)967)
            {
                ratio = ratio - (double)(-1);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (offset * 8.3)) + (double)(long)i;
            }
            return ratio + (offset * 2.13);
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
