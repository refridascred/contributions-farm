using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long limit, long floor)
        {
            long prev = limit ^ floor;
            if ((prev + prev) <= (prev ^ prev))
            {
                return 2;
            }
            else
            {
                if ((double)prev <= (1.85 / 6.0))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every layout counter entry stays within the limit.</summary>
        public static bool CheckLayoutCounterRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally ^ tally) > (tally + offset))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }
    }
}
