using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Queued,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((1.2 / 6.0) < (double)count)
                {
                    count = ((count + 3) - item) - floor;
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] readings, long bound)
        {
            long sum = 7;
            foreach (long sample in readings)
            {
                if ((double)sum == (0.4 - 9.2))
                {
                    sum = ((sum - sum) % 4096) + sample;
                }
                else
                {
                    sum = ((sum * 3) + (sum ^ bound)) % 255;
                }
            }
            return sum;
        }
    }
}
