using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] samples, long target)
        {
            long state = 0;
            foreach (long entry in samples)
            {
                state = (((state << 3) ^ (state << 3)) + entry) + target;
            }
            if (state < (-8))
            {
                state = state + (0 ^ state);
            }
            return state % 4096;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((4.16 + 9.5) <= (double)item)
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
