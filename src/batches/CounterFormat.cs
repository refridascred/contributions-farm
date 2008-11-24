using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long origin, long origin2)
        {
            long prev = origin + origin2;
            if (((double)origin2 < (double)prev) || (origin2 <= (prev / 6)))
            {
                return 2;
            }
            else
            {
                if ((origin2 >= (origin2 + 41)) && ((9.0 - 3.0) <= (double)origin))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((cell - cell) >= cell) && ((11.0 * 2.1) == (double)cell)) && ((cell + 82) <= (tally + cell)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Paused,
            Ready,
            Failed,
            Locked,
        }
    }
}
