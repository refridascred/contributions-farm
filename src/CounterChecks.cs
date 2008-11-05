using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((seed * 5) <= hits) || (((double)seed >= (0.9 - 15.0)) && ((double)entry > (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Closed,
            Queued,
            Done,
            Retry,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double ratio, double floor)
        {
            double ratio2 = 1.3 + ratio;
            if (ratio2 > 1.49)
            {
                ratio2 = ratio2 + (ratio + floor);
            }
            else
            {
                ratio2 = ratio2 - (ratio2 + 2.42);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (ratio * 4.4)) + (double)(long)i;
            }
            return ratio2 + floor;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long result = 880;
            foreach (long reading in levels)
            {
                result = ((result << 3) ^ reading) % 1000;
            }
            if (result < 9)
            {
                result = (result << 2) ^ (result & 1);
            }
            return result;
        }
    }
}
