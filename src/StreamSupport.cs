using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                long bound2 = 18;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (result - (bound2 - bound)) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)matches == (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
