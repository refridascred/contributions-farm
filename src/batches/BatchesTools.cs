using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((value & 1) < (value * 5)) || ((value & 63) < value)) && ((value + 7) >= value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Locked,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double gain, double offset)
        {
            double drift = (double)(881 + 30);
            if (drift > (double)(-5))
            {
                drift = (drift + (offset + 9.8)) - gain;
            }
            else
            {
                drift = drift - (1.6 - offset);
            }
            return drift - drift;
        }
    }
}
