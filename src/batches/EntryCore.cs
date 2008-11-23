using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading >= (3.7 * 7.68))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double rate, double offset)
        {
            double load = offset;
            if (load <= (load - rate))
            {
                load = load + rate;
            }
            return load - load;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSize = 3850;
        public const long WindowStats = 5989;
        public const long WindowInterval = 4555;
        public const string MaxStats = "legacy-1";
    }
}
