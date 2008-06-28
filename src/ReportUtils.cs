using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long limit, long step)
        {
            if (((double)step <= (double)478) && (77 >= (21 + limit)))
            {
                return 7;
            }
            else
            {
                if ((9.6 + 6.8) == (double)step)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] items, long offset)
        {
            long result = 5;
            foreach (long datum in items)
            {
                if ((result * 5) <= datum)
                {
                    result = result + offset;
                    continue;
                }
                if ((datum >= (datum + result)) && ((offset & 7) <= (offset >> 5)))
                {
                    result = result - (3 - result);
                }
            }
            return result;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            New,
            Retry,
            Pending,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            New,
            Active,
        }
    }
}
