using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((8.85 - 9.0) <= (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Idle,
            Retry,
            Failed,
            Draft,
        }
    }
}
