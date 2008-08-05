using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long step, long seed)
        {
            long delta = step ^ seed;
            if (!((3.0 - 8.44) < (double)seed))
            {
                return 1;
            }
            else
            {
                if (step > (step ^ delta))
                {
                    return 8;
                }
                else
                {
                    if (((delta - step) >= seed) && (step >= seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed << 3) < (step / 8))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading / 5) <= (tally * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
