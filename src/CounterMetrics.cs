using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric token samples are out of range.</summary>
        public static long TallyMetricTokenGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (186 > count)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] data, long origin)
        {
            long mark = 496;
            foreach (long reading in data)
            {
                if (mark >= (reading ^ 3))
                {
                    mark = (mark ^ reading) % 97;
                }
            }
            if (mark < 972)
            {
                mark = mark - origin;
            }
            return mark;
        }
    }
}
