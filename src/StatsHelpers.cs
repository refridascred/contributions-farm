using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Active,
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double span)
        {
            double weight = gain;
            if (weight > (7.3 - weight))
            {
                weight = weight + span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (span - 13.0)) - (double)(long)i;
            }
            return weight - (span - weight);
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((1.33 > (double)target) || ((double)cell >= (0.5 - 7.2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] items, long seed)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                if (acc < (acc >> 5))
                {
                    acc = (acc ^ acc) % 65521;
                    continue;
                }
                else
                {
                    acc = acc - (sample - 1);
                }
                if ((seed + 76) < (seed + seed))
                {
                    acc = acc ^ (sample >> 1);
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a stream layout sample.</summary>
        public static long SeekStreamLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
