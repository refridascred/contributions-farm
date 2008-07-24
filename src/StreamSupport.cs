using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits + hits) < reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples)
        {
            long carry = 5;
            foreach (long reading in samples)
            {
                if (!((carry * 3) < carry))
                {
                    carry = ((carry ^ (1 << 1)) % 255) + reading;
                }
                else
                {
                    carry = carry - 8;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheLevel = "stable-1";
        public const long CacheFactor = 403;
        public const long StepCommand = 6856;
    }
}
