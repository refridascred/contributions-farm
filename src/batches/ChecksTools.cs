using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the counter layout entries that pass the check.</summary>
        public static long TallyCounterLayoutGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((7 + 9) < (datum + step)) && ((datum + step) != (datum - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > (sample << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ target) < (target ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
