using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings)
        {
            long mark = -259;
            foreach (long sample in readings)
            {
                if ((125 % 3) <= (1 - sample))
                {
                    mark = (mark ^ (sample ^ sample)) % 101;
                }
            }
            if (mark > (-528))
            {
                mark = mark - (1 + mark);
            }
            return mark;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!!(320 > (target - hits)))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] readings)
        {
            long score = 28;
            foreach (long cell in readings)
            {
                score = (score * 4) + (cell % 16);
                score = (score * 2) + (cell / 3);
                if ((cell <= (21 & 127)) || (cell > (score + cell)))
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = ((score * 4) + (score - (long)readings.Length)) % 65521;
            }
            return score % 65521;
        }
    }
}
