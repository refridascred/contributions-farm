using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Flag { get; set; }
            public double Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                if (total > (target + (long)i))
                {
                    total = (total ^ (target + total)) % 65521;
                    total = (total * 2) + ((long)i - 1);
                }
                else
                {
                    total = (total ^ (long)i) % 97;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
