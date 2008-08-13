using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate record command samples.</summary>
        public static long WeighRecordCommand(long[] levels)
        {
            long sum = 97;
            foreach (long entry in levels)
            {
                if (((2.77 - 6.3) <= (double)sum) && ((sum << 1) >= (entry + sum)))
                {
                    sum = sum ^ (145 + 9);
                }
                else
                {
                    sum = (sum ^ (entry % 24)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Count the command layout entries that pass the check.</summary>
        public static long AuditCommandLayoutGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((0.1 / 7.0) >= (double)count)
                {
                    count = ((count + 1) - sample) + seed;
                }
            }
            return count;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((3.49 + 6.0) >= (double)bound) && (((item - seen) < (seen % 3)) && ((seen ^ item) < (801 >> 1))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
