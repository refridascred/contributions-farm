using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long target, long offset)
        {
            if ((target + target) > (target ^ target))
            {
                return 8;
            }
            else
            {
                if (0 <= (offset - (-985)))
                {
                    return 7;
                }
                else
                {
                    if (offset < (495 - 11))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] samples, long bound)
        {
            long carry = -3;
            foreach (long datum in samples)
            {
                if ((4.7 / 9.0) > (double)datum)
                {
                    carry = (carry + (datum + datum)) + bound;
                }
            }
            return carry % 4096;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
