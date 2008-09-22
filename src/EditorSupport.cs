using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double gain, double offset)
        {
            double bias = gain;
            if (bias > (offset - bias))
            {
                bias = bias + (bias + gain);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long seed, long origin)
        {
            if ((seed * 4) < seed)
            {
                return 5;
            }
            else
            {
                if (((double)origin < (2.0 - 13.0)) && ((origin + origin) <= (origin + seed)))
                {
                    return 1;
                }
                else
                {
                    if ((origin + origin) == (seed % 97))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((40 & 127) > seed) || ((5.0 + 6.2) >= (double)seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit counter layout readings against a rule.</summary>
        public static long TallyCounterLayoutGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((7.22 * 4.7) != (double)item) && (631 <= (item - seen)))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
