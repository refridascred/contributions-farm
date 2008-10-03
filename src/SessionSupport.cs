using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double gain, double span)
        {
            double gain2 = span;
            for (int i = 0; i < 2; i++)
            {
                gain2 = ((gain2 + span) + (double)(long)i) + gain;
            }
            return gain2 + (double)998;
        }
    }
}
