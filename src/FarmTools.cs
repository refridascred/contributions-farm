using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((offset - offset) >= tally))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Iterate the buffer contributi series from a seed.</summary>
        public static long RollBufferContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((double)origin == (2.0 * 4.3))
                {
                    sum = (sum + (33 >> 2)) % 4096;
                    sum = sum ^ ((long)i & 15);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate command contributi readings against a bound.</summary>
        public static bool ValidateCommandContributiRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
