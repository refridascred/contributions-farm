using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!(((double)reading == (0.1 * 3.0)) || ((double)matches != (5.7 - 5.3))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double bias, double offset)
        {
            double gain = 1.4 / 2.0;
            if (gain >= offset)
            {
                gain = (gain + 6.1) - bias;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - 14.0;
        }
    }
}
