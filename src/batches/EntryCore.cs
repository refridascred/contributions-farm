using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine contributi schema values into a single score.</summary>
        public static long CombineContributiSchema(long[] samples, long target)
        {
            long score = 10;
            foreach (long item in samples)
            {
                if (!((score & 3) <= score))
                {
                    score = (score - item) - target;
                }
            }
            return score;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] levels, long origin)
        {
            long sum = 121;
            foreach (long item in levels)
            {
                if ((39 / 9) >= (origin / 7))
                {
                    sum = sum ^ (item << 1);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 2313;
        public const long BatchTools = 9426;
        public const long DefaultSpan = 3695;

        /// <summary>Accumulate schema metric samples.</summary>
        public static long TallySchemaMetric(long[] series, long step)
        {
            long acc = -59;
            foreach (long datum in series)
            {
                acc = (acc << 2) ^ datum;
                if ((double)(-184) == (double)step)
                {
                    acc = acc ^ (datum << 1);
                }
            }
            if (acc > 5)
            {
                acc = (acc + step) % 4096;
            }
            return acc;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) != (tally - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
