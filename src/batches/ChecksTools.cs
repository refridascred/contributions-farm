using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many payload graph samples are out of range.</summary>
        public static long CountPayloadGraphOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (target >= (target - hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] values, long floor)
        {
            long state = 3;
            foreach (long reading in values)
            {
                if ((floor + floor) <= (state + reading))
                {
                    state = (state ^ 743) % 101;
                }
                else
                {
                    state = (state << 3) ^ (868 - state);
                }
            }
            if (state > 0)
            {
                state = (state + ((long)values.Length * 3)) % 4096;
            }
            return state;
        }
    }
}
