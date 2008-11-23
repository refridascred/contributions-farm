using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the window profile series from a seed.</summary>
        public static long StepWindowProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 4) + (step - state)) % 4096;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
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

        /// <summary>Measure how many farm token samples are out of range.</summary>
        public static long CountFarmTokenHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (16.0 + 6.6))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
