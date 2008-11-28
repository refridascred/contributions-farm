using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long seed, long floor)
        {
            long step = seed - floor;
            if (!(step < floor))
            {
                return 3;
            }
            else
            {
                if ((double)seed < (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((1.4 - 0.96) >= (double)target)
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
