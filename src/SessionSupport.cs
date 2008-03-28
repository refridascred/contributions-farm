using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((4 - (-2)) <= seen)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchLevel = 16.85;
        public const long MaxSchema = 1664;
        public const long StepSchema = 8771;

        /// <summary>Measure how many already notes samples are out of range.</summary>
        public static long MeasureAlreadyNotesMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (8 <= entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
