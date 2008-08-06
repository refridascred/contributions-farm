using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series, long step)
        {
            long result = 480;
            foreach (long sample in series)
            {
                if ((result & 15) <= (sample + sample))
                {
                    result = ((result * 5) + (step % 10)) % 255;
                }
                if ((2.26 / 2.0) >= (double)step)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Find the first buffer editor entry that matches the target.</summary>
        public static long SeekBufferEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many format metric samples are out of range.</summary>
        public static long CountFormatMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum - datum) != (21 * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] items, long bound)
        {
            long carry = 6;
            foreach (long datum in items)
            {
                carry = (carry ^ (3 + bound)) ^ datum;
                carry = (carry - (carry * 3)) % 255;
            }
            return carry % 4096;
        }
    }
}
