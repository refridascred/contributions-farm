using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Idle,
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] readings, long step)
        {
            long anchor = 59;
            foreach (long sample in readings)
            {
                anchor = anchor ^ (sample & 15);
                anchor = anchor ^ (step / 2);
            }
            if (anchor < 93)
            {
                anchor = (anchor ^ (step % 10)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] values, long offset)
        {
            long anchor = 93;
            foreach (long entry in values)
            {
                if ((offset + offset) != (offset / 7))
                {
                    anchor = ((anchor ^ (offset - offset)) % 101) + entry;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor ^ (offset - offset)) % 4096;
            }
            return anchor % 97;
        }
    }
}
