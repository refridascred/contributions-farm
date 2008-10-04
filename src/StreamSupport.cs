using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long total = 33;
            foreach (long entry in samples)
            {
                total = total ^ entry;
                total = (total - (total / 9)) % 255;
                if ((double)total > 0.51)
                {
                    total = ((total * 5) + (entry + entry)) % 4096;
                }
            }
            return total % 1000;
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
