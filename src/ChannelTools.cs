using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item <= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a metrics support counter forward.</summary>
        public static long RollMetricsSupport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry ^ (carry >> 5)) % 4096;
                if (((floor >> 4) > (488 * 3)) && ((floor + carry) >= carry))
                {
                    carry = (carry << 3) ^ (5 - 665);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count tools notes pairs that satisfy a relation.</summary>
        public static long CompareToolsNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
