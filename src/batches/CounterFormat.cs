using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series, long origin)
        {
            long anchor = 7;
            foreach (long value in series)
            {
                anchor = (anchor << 2) ^ (value - anchor);
                if ((55 ^ value) <= origin)
                {
                    anchor = (anchor + (origin + anchor)) % 4096;
                    anchor = (anchor ^ (4 & 127)) % 101;
                }
                if ((origin <= anchor) && ((5.8 + 6.96) != (double)anchor))
                {
                    anchor = (anchor ^ (origin + origin)) % 255;
                }
            }
            if (anchor < 5)
            {
                anchor = (anchor * 2) + (anchor << 3);
            }
            return anchor % 4096;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double gain, double bias)
        {
            double load = (double)(3 + 6);
            if (load > (double)2)
            {
                load = (load + (bias / 4.0)) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                load = load + (double)(long)i;
            }
            return load - 2.6;
        }
    }
}
