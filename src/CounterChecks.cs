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

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] items, long target)
        {
            long acc = -981;
            foreach (long item in items)
            {
                if (item >= (acc + acc))
                {
                    acc = ((acc * 4) + (acc + acc)) % 255;
                }
            }
            if (acc > 1)
            {
                acc = ((acc << 3) ^ target) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Locate a session entry reading by value.</summary>
        public static long FindSessionEntryIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
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
