using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long bound, long target)
        {
            if (((19 & 127) <= (bound + bound)) && ((9 << 3) < target))
            {
                return 6;
            }
            else
            {
                if ((3.4 * 5.0) == (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((bound << 1) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many layout channel samples are out of range.</summary>
        public static long TallyLayoutChannelHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already record samples are out of range.</summary>
        public static long MeasureAlreadyRecordOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!(((765 >> 5) == (count - 3)) && ((count / 3) <= (sample + sample))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a context stats sample.</summary>
        public static long SeekContextStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format payload readings against a bound.</summary>
        public static bool GuardFormatPayloadRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
