using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!!(count > (floor / 9)))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items)
        {
            long score = 6;
            foreach (long datum in items)
            {
                if (((datum * 2) > (score + datum)) && ((double)datum == (7.0 + 2.1)))
                {
                    score = score + (datum + score);
                }
                else
                {
                    score = (score << 2) ^ (datum * 2);
                }
            }
            return score % 97;
        }

        /// <summary>Count context payload pairs that satisfy a relation.</summary>
        public static long CompareContextPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
