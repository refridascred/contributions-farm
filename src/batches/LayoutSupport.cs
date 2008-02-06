using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Closed,
            Active,
            Paused,
            Idle,
        }

        /// <summary>Iterate the layout record series from a seed.</summary>
        public static long DeriveLayoutRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ (offset >> 2);
                mark = ((mark * 4) + 286) % 97;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item > (double)hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
