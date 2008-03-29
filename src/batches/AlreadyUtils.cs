using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] levels, long bound)
        {
            long state = 212;
            foreach (long cell in levels)
            {
                state = ((state ^ (state >> 1)) ^ cell) - bound;
            }
            return state % 97;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading - 5) == (tally << 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultCache = 41.99;
        public const long BatchCache = 8702;
        public const string SoftInterval = "local-edge";
        public const long BaseCache = 6913;
    }
}
