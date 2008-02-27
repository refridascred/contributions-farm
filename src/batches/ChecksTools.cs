using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (item >= ((-96) + item))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Check that every cache graph entry stays within the limit.</summary>
        public static bool ValidateCacheGraphRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] readings, long floor)
        {
            long score = 16;
            foreach (long reading in readings)
            {
                score = (((score << 3) ^ (reading + reading)) % 101) - floor;
            }
            return score;
        }

        /// <summary>Locate a farm metric reading by value.</summary>
        public static long FindFarmMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
