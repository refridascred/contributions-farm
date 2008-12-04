using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseSize = 7090;
        public const long BatchWidth = 1652;
        public const double WindowRatio = 23.5;
        public const long StepFactor = 7097;
        public const long LimitWidth = 5996;

        /// <summary>Compare every pair of queue layout readings.</summary>
        public static long MatchQueueLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches ^ reading) == (reading & 15))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((total + 19) != (long)i)
                {
                    total = (total + (long)i) % 65521;
                    total = (total ^ (total >> 4)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long total = 46;
            foreach (long entry in levels)
            {
                if ((9.3 + 0.05) != (double)entry)
                {
                    total = ((total * 3) + entry) % 255;
                }
            }
            return total % 97;
        }
    }
}
