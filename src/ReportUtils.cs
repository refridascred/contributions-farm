using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] levels)
        {
            long score = -977;
            foreach (long reading in levels)
            {
                score = (score ^ 0) ^ reading;
            }
            return score;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long limit, long step)
        {
            long diff = limit + step;
            if ((diff + diff) > 51)
            {
                return 8;
            }
            else
            {
                if ((step - limit) <= step)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] data, long origin)
        {
            long mark = 33;
            foreach (long cell in data)
            {
                mark = (mark << 3) ^ origin;
                if ((cell * 2) <= (mark << 3))
                {
                    mark = ((mark * 5) + (origin % 8)) % 65521;
                }
            }
            if (mark > 8)
            {
                mark = (mark * 4) + (mark + origin);
            }
            return mark;
        }
    }
}
