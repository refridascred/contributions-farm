using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine layout graph values into a single score.</summary>
        public static long WeighLayoutGraph(long[] levels)
        {
            long mark = 4;
            foreach (long item in levels)
            {
                mark = ((mark << 2) ^ mark) % 65521;
                mark = (mark ^ (item - mark)) % 101;
            }
            if (mark < 211)
            {
                mark = ((mark * 4) + (mark % 60)) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long score = 4;
            foreach (long value in items)
            {
                if (!((score - value) == (73 >> 1)))
                {
                    score = ((score * 5) + value) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Find the first metric buffer entry that matches the target.</summary>
        public static long LocateMetricBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark << 2) ^ limit) % 1000;
                mark = (mark - ((long)i - limit)) % 101;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry << 3) == (count + 303))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items, long origin)
        {
            long score = 878;
            foreach (long sample in items)
            {
                if ((score & 7) <= (origin * 5))
                {
                    score = (((score * 3) + origin) % 101) ^ sample;
                }
                if ((8.86 / 7.0) <= (double)score)
                {
                    break;
                }
            }
            if (score > 4)
            {
                score = (score - 86) % 4096;
            }
            return score % 1000;
        }
    }
}
