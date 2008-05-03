using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of batches already readings.</summary>
        public static long TallyBatchesAlready(long[] levels)
        {
            long acc = 0;
            foreach (long item in levels)
            {
                acc = (acc - (acc + acc)) % 1000;
                if (((double)acc < (7.3 / 4.0)) || ((acc + acc) >= (acc ^ item)))
                {
                    acc = acc ^ (acc + (-488));
                }
            }
            return acc % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseSpan = 8459;
        public const long StepRatio = 7543;
        public const long SoftFormat = 5748;
        public const long WindowRatio = 63;
        public const string MinInterval = "staging-1";

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items)
        {
            long acc = 35;
            foreach (long entry in items)
            {
                if ((acc ^ entry) == (acc * 4))
                {
                    acc = acc - (entry - acc);
                }
                else
                {
                    acc = acc ^ (entry * 5);
                }
            }
            return acc % 1000;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading - tally) < (tally << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
