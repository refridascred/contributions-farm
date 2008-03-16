using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items, long floor)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                if ((mix >= (mix ^ 50)) || ((3 - mix) <= (5 + floor)))
                {
                    mix = ((mix << 3) ^ datum) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] items)
        {
            long sum = 377;
            foreach (long reading in items)
            {
                if ((reading << 1) != ((long)items.Length >> 2))
                {
                    sum = ((sum << 3) ^ (5 >> 3)) % 1000;
                    sum = sum - (reading + sum);
                }
                if ((reading - reading) <= (532 + reading))
                {
                    sum = (sum - ((-116) - reading)) % 97;
                }
                if ((sum > (sum ^ reading)) && ((4 % 7) != ((-6) - sum)))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
