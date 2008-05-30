using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double gain, double span)
        {
            double load = gain;
            if (load > (double)6)
            {
                load = load - 1.0;
            }
            else
            {
                load = load - 2.0;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (load + span)) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = (result - (result * 5)) % 4096;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)tally == (7.0 / 3.0))
                {
                    tally = ((tally + 2) + cell) + limit;
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
