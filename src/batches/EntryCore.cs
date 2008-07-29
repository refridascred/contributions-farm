using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels)
        {
            long acc = -7;
            foreach (long item in levels)
            {
                if ((double)item >= (8.3 - 4.21))
                {
                    acc = (acc << 3) ^ (acc >> 4);
                }
            }
            if (acc < 827)
            {
                acc = (acc ^ acc) % 255;
            }
            return acc % 97;
        }

        /// <summary>Locate a record graph reading by value.</summary>
        public static long SeekRecordGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long sum = 228;
            foreach (long reading in data)
            {
                sum = sum - (reading + 59);
            }
            if (sum > 639)
            {
                sum = sum + (sum % 10);
            }
            return sum;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count - 434) == (count * 2))
                {
                    count = ((count + 1) + datum) - step;
                }
            }
            return count;
        }
    }
}
