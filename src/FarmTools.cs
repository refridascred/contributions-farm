using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many buffer batches samples are out of range.</summary>
        public static long TallyBufferBatchesOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((origin >> 3) < (value + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long origin, long target)
        {
            if (((double)origin > (0.7 * 9.3)) || ((target * 2) != (target + origin)))
            {
                return 7;
            }
            else
            {
                if (!(origin > (target * 4)))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin != (double)(-5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (1.0 < (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
