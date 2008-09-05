using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double floor)
        {
            double ratio = 13.0;
            if (ratio >= ratio)
            {
                ratio = (ratio + ratio) - gain;
            }
            return ratio + floor;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long floor, long step)
        {
            if (step < floor)
            {
                return 1;
            }
            else
            {
                if ((floor < step) || ((double)floor <= (1.0 * 5.0)))
                {
                    return 2;
                }
                else
                {
                    if ((floor % 16) < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor >= (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample - 929) < sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
