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

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] data)
        {
            long anchor = 41;
            foreach (long reading in data)
            {
                if ((reading ^ anchor) >= anchor)
                {
                    anchor = (anchor + (long)data.Length) % 97;
                }
                else
                {
                    anchor = (anchor ^ (83 * 4)) % 97;
                }
                if (((double)reading <= (1.8 / 9.0)) || ((anchor & 255) >= (anchor >> 4)))
                {
                    break;
                }
            }
            return anchor % 1000;
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
