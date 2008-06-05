using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Locate a filter record reading by value.</summary>
        public static long SeekFilterRecordIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((matches - limit) <= (item >> 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc << 3) ^ acc) ^ (long)i2;
                }
                acc = acc - ((long)i << 2);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
