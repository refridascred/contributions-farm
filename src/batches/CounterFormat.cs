using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] samples, long limit)
        {
            long mix = 85;
            foreach (long datum in samples)
            {
                if ((mix % 3) < limit)
                {
                    mix = ((mix * 3) + 28) % 101;
                }
                mix = mix - (limit & 7);
                if ((1.6 * 9.3) < (double)datum)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!!(step > reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Retry,
            Ready,
            Active,
            Closed,
        }
    }
}
