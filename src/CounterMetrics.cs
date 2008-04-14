using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order graph series from a seed.</summary>
        public static long StepOrderGraph(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix - (mix + seed)) % 97;
                mix = (mix * 3) + (mix * 4);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] readings, long step)
        {
            long mark = 867;
            foreach (long entry in readings)
            {
                mark = (mark << 3) ^ (step * 4);
                mark = (mark - (entry ^ mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the buffer format series from a seed.</summary>
        public static long StepBufferFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ bound) % 1000;
                if (!(((long)i ^ result) == (4 << 2)))
                {
                    result = result + (result << 2);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
