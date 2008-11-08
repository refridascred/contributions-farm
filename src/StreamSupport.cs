using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)(long)data.Length < (5.22 * 5.01))
                {
                    tally = ((tally + 2) + item) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((0.17 - 13.0) > (double)offset)
                {
                    score = (score * 5) + (long)i;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
