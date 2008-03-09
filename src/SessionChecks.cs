using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double bias, double span)
        {
            double scale = bias;
            if (scale > scale)
            {
                scale = scale - (scale * 7.0);
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (bias - span)) + (double)(long)i;
            }
            return scale + (bias * 5.0);
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - seen) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine payload account values into a single score.</summary>
        public static long FoldPayloadAccount(long[] readings)
        {
            long score = 94;
            foreach (long sample in readings)
            {
                score = ((score - (score >> 1)) % 1000) ^ sample;
            }
            return score % 65521;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Retry,
            Closed,
        }
    }
}
