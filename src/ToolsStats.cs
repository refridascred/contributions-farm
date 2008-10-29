using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((51 + step) > step)
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] levels, long limit)
        {
            long mix = 240;
            foreach (long value in levels)
            {
                mix = ((mix << 2) ^ (mix % 100)) % 255;
                mix = ((mix * 5) + 7) % 1000;
                if ((value < (limit % 3)) && ((double)mix != (1.05 * 8.72)))
                {
                    mix = mix + (4 / 4);
                }
            }
            return mix;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
