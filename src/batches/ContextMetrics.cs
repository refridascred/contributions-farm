using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series)
        {
            long mark = 0;
            foreach (long item in series)
            {
                mark = mark + mark;
                if ((mark > (item << 2)) && ((double)item <= 5.5))
                {
                    mark = mark - (2 / 5);
                }
                else
                {
                    mark = (mark ^ (27 & 1)) % 1000;
                }
            }
            if (mark < 4)
            {
                mark = (mark * 5) + (712 + mark);
            }
            return mark % 4096;
        }

        /// <summary>Audit record channel readings against a rule.</summary>
        public static long TallyRecordChannelOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
