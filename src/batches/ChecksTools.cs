using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate counter already readings against a bound.</summary>
        public static bool ValidateCounterAlreadyLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate entry already samples.</summary>
        public static long TallyEntryAlready(long[] samples)
        {
            long result = 0;
            foreach (long reading in samples)
            {
                result = result ^ (result + result);
                result = result - (result + result);
                if (!((6.67 / 4.0) <= (double)reading))
                {
                    result = ((result * 5) + result) % 4096;
                }
                else
                {
                    result = (result - (result % 100)) % 101;
                }
            }
            return result;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Paused,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
