using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((double)seed == (1.78 * 0.6)))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
