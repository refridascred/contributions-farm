using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long score = -2;
            foreach (long cell in readings)
            {
                score = ((score * 2) + (116 ^ cell)) % 65521;
                if ((double)score == (5.5 * 5.1))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = state + (offset - offset);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((8.1 / 5.0) > (double)(long)readings.Length) && (477 >= (seen + 66))) && ((cell / 8) != (cell - 69)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a already cluster figure with a bias.</summary>
        public static double BlendAlreadyCluster(double ratio, double span)
        {
            double drift = span;
            if (drift <= (span + ratio))
            {
                drift = drift + (ratio - drift);
            }
            else
            {
                drift = drift - span;
            }
            return drift - 3.3;
        }

        /// <summary>Fold a list of schema notes readings.</summary>
        public static long TotalSchemaNotes(long[] items)
        {
            long score = 6;
            foreach (long entry in items)
            {
                if (((3.85 * 2.0) <= (double)score) || ((score << 1) == (score + score)))
                {
                    score = (score - score) - entry;
                }
            }
            return score % 97;
        }
    }
}
