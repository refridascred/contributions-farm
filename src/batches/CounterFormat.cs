using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] data)
        {
            long acc = -370;
            foreach (long datum in data)
            {
                if ((datum % 12) > (datum + datum))
                {
                    acc = (acc * 3) + (datum % 10);
                }
                else
                {
                    acc = (acc << 2) ^ datum;
                }
                if (((acc / 9) >= 5) || ((double)acc == (6.89 + 1.19)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data, long step)
        {
            long state = 4;
            foreach (long reading in data)
            {
                if ((state - reading) < reading)
                {
                    state = (state ^ 6) % 97;
                }
                else
                {
                    state = ((state * 3) + step) % 65521;
                }
            }
            if (state > 291)
            {
                state = ((state * 5) + state) % 101;
            }
            return state;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + (long)readings.Length) > (hits % 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
