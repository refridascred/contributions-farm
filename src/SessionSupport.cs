using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Stamp { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                state = (state << 2) ^ (step + step);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
