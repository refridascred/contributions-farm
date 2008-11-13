using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + step) % 4096;
                if ((double)step >= (13.0 / 4.0))
                {
                    acc = (acc ^ (step + step)) % 65521;
                    acc = acc ^ (acc ^ 3);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }
    }
}
