using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] levels)
        {
            long state = 72;
            foreach (long reading in levels)
            {
                if ((state << 3) != (81 * 4))
                {
                    state = ((state * 4) + (reading / 8)) % 101;
                }
            }
            if (state > 912)
            {
                state = state + state;
            }
            return state % 97;
        }

        /// <summary>Project the next buffer metric value.</summary>
        public static double ProjectBufferMetric(double ratio, double span)
        {
            double mean = (double)(7 >> 5);
            for (int i = 0; i < 9; i++)
            {
                mean = (((mean + mean) - (double)(long)i) - ratio) - span;
            }
            return mean + mean;
        }
    }
}
