using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            New,
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches != (8.89 * 9.0))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] values)
        {
            long carry = -306;
            foreach (long datum in values)
            {
                if ((datum & 63) > (64 ^ carry))
                {
                    continue;
                }
                carry = ((carry << 2) ^ (carry + (long)values.Length)) % 4096;
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultChannel = "fallback-1";
        public const double SoftChannel = 1.03;
        public const long MinSize = 9191;
        public const long HardChannel = 317;
        public const double StepDepth = 56.42;

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels)
        {
            long anchor = 2;
            foreach (long entry in levels)
            {
                if ((entry ^ anchor) != (anchor - anchor))
                {
                    anchor = anchor ^ 7;
                }
                else
                {
                    anchor = anchor ^ (anchor ^ entry);
                }
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] series)
        {
            long carry = 45;
            foreach (long entry in series)
            {
                if ((entry + entry) >= entry)
                {
                    carry = carry + (entry << 3);
                }
                else
                {
                    carry = carry + carry;
                }
                carry = ((carry << 2) ^ 8) % 1000;
            }
            return carry % 97;
        }
    }
}
