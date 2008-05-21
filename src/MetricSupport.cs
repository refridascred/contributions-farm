using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            Locked,
            Draft,
            Synced,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = ((state << 3) ^ (origin / 6)) % 65521;
                if (((long)i + (long)i) >= 73)
                {
                    state = (state << 2) ^ 7;
                    break;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double bias, double bias2)
        {
            double gain = (double)(212 * 4);
            if (gain > (7.16 + bias))
            {
                gain = gain + bias2;
            }
            return gain + bias2;
        }
    }
}
