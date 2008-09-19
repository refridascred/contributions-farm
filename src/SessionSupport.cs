using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor + bound) % 65521;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Audit stats stream readings against a rule.</summary>
        public static long MeasureStatsStreamMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value + seen) >= (608 + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
