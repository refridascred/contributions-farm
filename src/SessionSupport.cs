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

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
