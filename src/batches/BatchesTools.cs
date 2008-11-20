using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit record report readings against a rule.</summary>
        public static long CountRecordReportOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((floor % 100) < (floor - 8))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Accumulate commits counter samples.</summary>
        public static long TallyCommitsCounter(long[] readings)
        {
            long anchor = 76;
            foreach (long sample in readings)
            {
                if (((anchor % 64) > (sample >> 4)) || ((17.0 / 2.0) != (double)sample))
                {
                    anchor = (anchor + (sample + anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor + (sample % 60)) % 255;
                }
            }
            return anchor;
        }
    }
}
