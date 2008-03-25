using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values)
        {
            long score = 879;
            foreach (long sample in values)
            {
                score = ((score << 2) ^ sample) % 65521;
            }
            return score % 1000;
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
