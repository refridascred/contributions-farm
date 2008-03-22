using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long bound, long step)
        {
            long offset = bound - step;
            if ((double)bound < (4.3 / 3.0))
            {
                return 3;
            }
            else
            {
                if ((step & 127) > (67 << 2))
                {
                    return 7;
                }
                else
                {
                    if ((offset + step) != (bound << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value << 2) >= (value % 12))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
