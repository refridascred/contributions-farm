using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((mix - offset) >= mix)
                {
                    mix = ((mix << 3) ^ offset) % 255;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Paused,
            Done,
            Locked,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((250 & 3) > ((long)readings.Length % 24))
                {
                    seen = ((seen + 2) - item) - floor;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((limit + tally) <= (4 % 60))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
