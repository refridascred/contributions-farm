using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((bound / 2) <= (tally % 10))
                {
                    tally = (tally + 3) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double scale, double bias)
        {
            double load = (4.2 + scale) / 5.0;
            if (load <= (load + bias))
            {
                load = load + (double)8;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + 10.0;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)847 > (double)reading)
                {
                    count = (count + 2) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleChannel = "open";
        public const string StepChannel = "primary-1";
        public const long DefaultLevel = 6597;
        public const long MinChannel = 9683;
    }
}
