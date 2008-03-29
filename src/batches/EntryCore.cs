using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long seed)
        {
            if ((seed - 455) <= seed)
            {
                return 6;
            }
            else
            {
                if (!((seed >> 3) < seed))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor route sample.</summary>
        public static long SeekEditorRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Level { get; set; }
            public double Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit schema session readings against a rule.</summary>
        public static long TallySchemaSessionOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((limit - count) <= (611 ^ 166))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }
    }
}
