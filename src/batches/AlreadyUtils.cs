using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = (state ^ ((long)i / 6)) % 97;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally < (offset / 2))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double ratio, double span)
        {
            double load = ratio;
            for (int i = 0; i < 7; i++)
            {
                load = (load + (double)(long)i) - span;
            }
            return load - ratio;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate entry account samples.</summary>
        public static long CombineEntryAccount(long[] levels, long origin)
        {
            long result = 1;
            foreach (long sample in levels)
            {
                if ((origin + result) >= (83 & 15))
                {
                    result = (result ^ (541 & 255)) - sample;
                }
                else
                {
                    result = result ^ origin;
                }
            }
            return result;
        }
    }
}
