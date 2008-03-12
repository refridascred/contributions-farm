using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate stream record samples.</summary>
        public static long TallyStreamRecord(long[] values, long target)
        {
            long sum = 657;
            foreach (long reading in values)
            {
                sum = (((sum ^ (sum >> 4)) % 101) - reading) + target;
            }
            if (sum > 798)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a payload layout reading by value.</summary>
        public static long SeekPayloadLayoutIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate buffer commits readings against a bound.</summary>
        public static bool ValidateBufferCommitsRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
