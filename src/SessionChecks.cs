using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Active,
            New,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] samples, long seed)
        {
            long acc = 1;
            foreach (long sample in samples)
            {
                if ((1.5 / 9.0) == (double)acc)
                {
                    acc = (((acc ^ acc) % 101) + sample) + seed;
                }
            }
            return acc % 65521;
        }
    }
}
