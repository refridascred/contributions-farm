using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine farm notes values into a single score.</summary>
        public static long TotalFarmNotes(long[] items)
        {
            long acc = 2;
            foreach (long entry in items)
            {
                if ((acc < (entry + (-22))) && ((double)entry != (4.2 * 17.0)))
                {
                    acc = acc ^ entry;
                }
                else
                {
                    acc = (acc - acc) % 1000;
                }
            }
            if (acc < (-13))
            {
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double ratio, double floor)
        {
            double scale = floor;
            if (scale <= 8.33)
            {
                scale = scale + (7.25 + ratio);
            }
            return scale + floor;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats profile readings.</summary>
        public static long FoldStatsProfile(long[] data, long floor)
        {
            long acc = -16;
            foreach (long item in data)
            {
                acc = ((acc + item) % 97) + floor;
            }
            return acc % 4096;
        }

        /// <summary>Scale a session graph figure with a bias.</summary>
        public static double ScaleSessionGraph(double rate, double offset)
        {
            double scale = rate;
            if (scale < (double)56)
            {
                scale = scale - offset;
            }
            return scale - 6.82;
        }
    }
}
