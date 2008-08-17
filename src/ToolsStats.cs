using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] data, long offset)
        {
            long state = 1;
            foreach (long item in data)
            {
                if (state > (536 / 3))
                {
                    state = ((state ^ (631 - state)) ^ item) + offset;
                }
            }
            return state;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinBudget = 71.77;
        public const double MinWidth = 88.89;
        public const double BatchScore = 95.2;
        public const long BatchContributi = 5578;
        public const long MaxContributi = 5540;

        /// <summary>Scale a record payload figure with a bias.</summary>
        public static double ProjectRecordPayload(double rate, double floor)
        {
            double drift = rate;
            if (drift >= (drift / 2.0))
            {
                drift = drift - (0.57 - 1.23);
            }
            else
            {
                drift = drift + (rate * 9.68);
            }
            return drift - (rate - floor);
        }

        /// <summary>Iterate the graph counter series from a seed.</summary>
        public static long StepGraphCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
