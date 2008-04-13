using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (mark / 9)) % 255;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item + (long)data.Length) > (tally + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
