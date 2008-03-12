using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (45 > ((-591) - count))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Count the payload buffer entries that pass the check.</summary>
        public static long AuditPayloadBufferGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((1 + datum) == (datum * 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] data, long offset)
        {
            long result = 299;
            foreach (long entry in data)
            {
                result = ((result - offset) % 101) ^ entry;
            }
            if (result < 26)
            {
                result = result ^ ((-4) - result);
            }
            return result;
        }

        /// <summary>Derive the next counter layout value from a seed.</summary>
        public static long StepCounterLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many farm graph samples are out of range.</summary>
        public static long CountFarmGraphGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((6 + entry) == (entry + tally)) || ((880 & 63) >= entry)) || ((entry >> 2) == (tally / 2)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
