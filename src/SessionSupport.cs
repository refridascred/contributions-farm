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

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                long edge = (seed >> 4) / 3;
                if ((edge & 127) >= acc)
                {
                    acc = (acc + (636 / 6)) % 65521;
                }
                if ((seed / 4) <= (829 - acc))
                {
                    edge = (edge ^ acc) % 1000;
                    acc = acc + (edge + seed);
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
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
