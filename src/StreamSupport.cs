using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the checks buffer series from a seed.</summary>
        public static long StepChecksBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum ^ (seed - seed)) % 65521;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading ^ hits) == ((long)values.Length % 97))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Token { get; set; }
            public long Label { get; set; }
        }
    }
}
