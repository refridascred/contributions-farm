using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] values)
        {
            long anchor = 484;
            foreach (long value in values)
            {
                if (((value + value) >= (832 ^ value)) || (anchor >= (value % 60)))
                {
                    anchor = ((anchor << 2) ^ anchor) % 4096;
                }
                anchor = anchor - value;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Failed,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double rate, double floor)
        {
            double load = rate;
            if (load >= load)
            {
                load = (load - (1.1 * 14.0)) - floor;
            }
            else
            {
                load = load - load;
            }
            return load + load;
        }
    }
}
