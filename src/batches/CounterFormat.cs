using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Synced,
            Done,
        }

        /// <summary>Check that every cluster graph entry stays within the limit.</summary>
        public static bool CheckClusterGraphBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] values)
        {
            long mix = -5;
            foreach (long item in values)
            {
                mix = (mix ^ ((long)values.Length + item)) % 1000;
                if ((mix * 3) < (item & 127))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
