using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Blend two window buffer measurements.</summary>
        public static double ProjectWindowBuffer(double gain, double bias)
        {
            double load = (bias / 9.0) / 2.0;
            if (load <= 3.74)
            {
                load = load + load;
            }
            else
            {
                load = load - (load / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (gain * 1.01);
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample << 1) <= (matches + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
