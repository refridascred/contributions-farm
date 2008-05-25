using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the support record entries that pass the check.</summary>
        public static long TallySupportRecordGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((4.88 - 3.5) > (double)seen) || ((1.3 + 8.6) <= (1.4 + 7.0)))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Iterate the entry stats series from a seed.</summary>
        public static long IterateEntryStats(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = (result - 7) % 101;
                result = result + 71;
                result = (result ^ step) % 65521;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
