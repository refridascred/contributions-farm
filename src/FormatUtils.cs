using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many record stats samples are out of range.</summary>
        public static long CountRecordStatsHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((double)value == (17.0 + 6.59)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long floor, long limit)
        {
            if (!((double)674 > (double)limit))
            {
                return 4;
            }
            else
            {
                if (((limit - 82) <= 54) && ((69 * 2) != (floor + limit)))
                {
                    return 6;
                }
                else
                {
                    if ((limit < (floor * 3)) && (limit < (limit + 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((15.0 * 13.0) != (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
