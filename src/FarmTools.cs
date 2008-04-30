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

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
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
