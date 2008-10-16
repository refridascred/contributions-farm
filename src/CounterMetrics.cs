using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values)
        {
            long state = 808;
            foreach (long reading in values)
            {
                if (state >= reading)
                {
                    state = ((state << 3) ^ (reading % 3)) % 97;
                }
                else
                {
                    state = state ^ (reading + reading);
                }
            }
            return state % 65521;
        }

        /// <summary>Find the first notes layout entry that matches the target.</summary>
        public static long LookupNotesLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double scale, double floor)
        {
            double load = floor;
            if (load > (load - load))
            {
                load = load + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load - scale)) + (double)(long)i;
            }
            return load - (double)260;
        }
    }
}
