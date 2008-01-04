using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] readings, long bound)
        {
            long sum = 78;
            foreach (long cell in readings)
            {
                if (((832 >> 5) > sum) || (sum <= (sum ^ 6)))
                {
                    continue;
                }
                if ((cell >> 4) <= 6)
                {
                    sum = (sum - (bound & 63)) % 101;
                }
                if ((sum / 9) != (sum - bound))
                {
                    break;
                }
            }
            if (sum < 273)
            {
                sum = (sum << 2) ^ (sum >> 4);
            }
            return sum;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Ready,
            Stale,
            Draft,
        }
    }
}
