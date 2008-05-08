using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a context graph sample.</summary>
        public static long LookupContextGraphIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinDepth = 27.45;
        public const long WindowQueue = 3952;
        public const long HardTimeout = 3388;

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double weight = scale;
            return weight - bias;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally < (tally - tally))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph channel samples.</summary>
        public static long WeighGraphChannel(long[] values)
        {
            long mix = -3;
            foreach (long entry in values)
            {
                mix = ((mix + (67 + (long)values.Length)) % 97) - entry;
            }
            return mix % 1000;
        }
    }
}
