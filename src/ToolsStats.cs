using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context metrics value from a seed.</summary>
        public static long SeriesContextMetrics(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((11.0 - 12.0) <= (double)step))
                {
                    carry = (carry - ((long)i << 2)) % 97;
                }
                carry = (carry - (carry ^ step)) % 65521;
                carry = (carry << 3) ^ (step - carry);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!(origin >= (sample + 7)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
