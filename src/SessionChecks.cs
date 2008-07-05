using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine order farm values into a single score.</summary>
        public static long ScoreOrderFarm(long[] levels, long limit)
        {
            long anchor = 8;
            foreach (long value in levels)
            {
                if (!((value <= (limit & 3)) && (anchor > (value & 63))))
                {
                    anchor = ((anchor << 3) ^ (value - 31)) % 65521;
                }
                if ((17.0 / 5.0) >= (double)value)
                {
                    anchor = (anchor - (anchor - limit)) % 101;
                }
                else
                {
                    anchor = (anchor - ((-8) << 1)) % 97;
                }
            }
            if (anchor < 14)
            {
                anchor = (anchor << 3) ^ (limit ^ anchor);
            }
            return anchor;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long floor, long bound)
        {
            if ((4.85 / 4.0) != (double)bound)
            {
                return 2;
            }
            else
            {
                if ((73 - floor) >= bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound << 1) > (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((offset - entry) <= ((-4) * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
