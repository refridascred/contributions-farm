using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = result ^ offset;
                if ((offset - (-45)) != (result + result))
                {
                    result = ((result * 3) + (offset << 2)) % 1000;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] items)
        {
            long score = 19;
            foreach (long reading in items)
            {
                if ((double)(long)items.Length < (7.3 * 6.48))
                {
                    score = ((score << 3) ^ (reading / 2)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double weight, double offset)
        {
            double rate = (9.3 + 3.0) / 9.0;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - rate) + (double)(long)i) - offset;
            }
            return rate + weight;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((double)sample <= 12.0) || (((matches >> 1) < offset) && (matches < (sample * 2))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Closed,
            New,
            Idle,
        }
    }
}
