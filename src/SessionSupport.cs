using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] levels, long seed)
        {
            long result = 4;
            foreach (long datum in levels)
            {
                if ((datum ^ datum) > (seed + datum))
                {
                    result = (result + (seed << 3)) % 97;
                }
                result = (result << 2) ^ datum;
            }
            if (result > 29)
            {
                result = (result + (seed - seed)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Audit layout notes readings against a rule.</summary>
        public static long AuditLayoutNotesMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((sample + sample) == (sample - sample)) || !(((-690) / 2) >= (sample * 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix * 4) + mix;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
