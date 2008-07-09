using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading - reading) == (seen & 127))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] levels)
        {
            long acc = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell << 2))
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = acc - (62 >> 3);
                }
            }
            if (acc > 233)
            {
                acc = acc ^ (acc - acc);
            }
            return acc;
        }
    }
}
