using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first stream buffer entry that matches the target.</summary>
        public static long SeekStreamBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Failed,
            Queued,
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] levels)
        {
            long mark = 0;
            foreach (long item in levels)
            {
                mark = ((mark << 3) ^ (616 >> 3)) - item;
            }
            return mark;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
