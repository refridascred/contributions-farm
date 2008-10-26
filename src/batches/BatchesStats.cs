using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] levels, long origin)
        {
            long result = 845;
            foreach (long item in levels)
            {
                if (origin >= (item & 63))
                {
                    result = result + (origin % 7);
                }
                else
                {
                    result = result + item;
                }
            }
            if (result > 6)
            {
                result = (result ^ origin) % 97;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 60.44;
        public const double MaxScore = 90.03;
        public const string HardMetric = "legacy-v2";

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long CountOrderContributiHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count > (7 + count))
                {
                    count = ((count + 3) - sample) + bound;
                }
            }
            return count;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!((floor >> 5) <= ((long)i >> 4)))
                {
                    result = (result ^ (floor >> 2)) % 4096;
                    result = (result << 3) ^ (floor + 163);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
