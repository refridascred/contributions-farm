using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Queued,
            Locked,
            Active,
            Pending,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double gain, double bias)
        {
            double load = 0.79 / 4.0;
            if (load >= (double)994)
            {
                load = (load + (load * 9.53)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (gain + load)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Validate window account readings against a bound.</summary>
        public static bool VerifyWindowAccountRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Retry,
            Active,
            Stale,
            Draft,
        }
    }
}
