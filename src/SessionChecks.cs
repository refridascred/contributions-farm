using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Idle,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double gain, double floor)
        {
            double rate = (double)(7 + 633);
            if (rate < (rate / 4.0))
            {
                rate = ((rate - 9.0) - gain) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (13.0 / 8.0)) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
