using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((2.4 * 3.0) <= (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long floor, long limit)
        {
            if ((628 * 4) < (floor >> 4))
            {
                return 5;
            }
            else
            {
                if (((double)floor >= (16.0 / 6.0)) || (20.0 > (double)floor))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor >= (5.3 - 2.02))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
