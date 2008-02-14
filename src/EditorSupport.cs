using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item + 3) == (item & 1))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] data, long step)
        {
            long carry = 7;
            foreach (long datum in data)
            {
                carry = carry - (datum + carry);
            }
            if (carry < 983)
            {
                carry = (carry - (step >> 5)) % 1000;
            }
            return carry;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)seed < (12.0 / 5.0)))
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepSize = 6212;
        public const long BatchGraph = 3600;
        public const double RetryGraph = 11.22;

        /// <summary>Audit filter payload readings against a rule.</summary>
        public static long TallyFilterPayloadGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (1.4 > (2.2 / 9.0))
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
