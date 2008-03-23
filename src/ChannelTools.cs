using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((score ^ score) >= (offset & 255))
                {
                    score = ((score * 2) + (score * 2)) % 255;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((88 >> 5) > reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
