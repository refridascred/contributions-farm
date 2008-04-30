using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support metric samples.</summary>
        public static long DigestSupportMetric(long[] data, long floor)
        {
            long total = 782;
            foreach (long reading in data)
            {
                total = ((total << 2) ^ (floor - (long)data.Length)) ^ reading;
            }
            return total % 4096;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long seed, long limit)
        {
            long span = seed + limit;
            if ((span % 16) < (seed - 7))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) <= (span >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((seed ^ span) > (15 & 15))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)span > (3.49 / 5.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
