using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next payload format value from a seed.</summary>
        public static long IteratePayloadFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] data, long target)
        {
            long score = 5;
            foreach (long item in data)
            {
                if (score < target)
                {
                    score = ((score * 2) + (item + item)) % 65521;
                }
                else
                {
                    score = ((score * 5) + (item ^ score)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((3.0 + 7.0) > (double)matches) || (((459 % 97) != (matches - matches)) && ((item ^ matches) != (item + item))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Closed,
            Done,
        }
    }
}
