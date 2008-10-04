using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples)
        {
            long anchor = 2;
            foreach (long datum in samples)
            {
                if (((datum % 8) > (long)samples.Length) || ((datum >> 3) <= (anchor + anchor)))
                {
                    anchor = anchor + ((long)samples.Length + 115);
                }
            }
            return anchor;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if ((2.14 * 15.0) <= (double)score)
                {
                    score = ((score << 3) ^ target) % 101;
                }
                else
                {
                    score = score - (target << 2);
                }
                score = (score * 3) + (long)i;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((long)values.Length & 1) > (-77))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
