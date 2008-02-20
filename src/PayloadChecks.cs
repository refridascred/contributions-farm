using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a batch channel reading.</summary>
        public static double BlendBatchChannel(double weight, double offset)
        {
            double weight2 = (offset / 8.0) * 2.4;
            if (weight2 > weight)
            {
                weight2 = weight2 - (weight2 - offset);
            }
            else
            {
                weight2 = weight2 + (weight2 * 1.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - (offset / 6.0)) - (double)(long)i;
            }
            return weight2 - weight;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Dropped,
            Closed,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item * 4) <= (matches + 69))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] series, long seed)
        {
            long mark = -981;
            foreach (long reading in series)
            {
                if ((3.8 * 3.98) != (double)reading)
                {
                    mark = (mark << 3) ^ (mark - seed);
                }
            }
            return mark;
        }

        /// <summary>Locate a farm already reading by value.</summary>
        public static long FindFarmAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
