using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] values, long bound)
        {
            long mark = 93;
            foreach (long value in values)
            {
                if (((mark * 3) == (61 * 5)) && ((bound << 1) < (mark + 486)))
                {
                    mark = (mark ^ (value - 6)) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ (bound - mark);
                }
            }
            return mark % 65521;
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

        /// <summary>Check that every tools account entry stays within the limit.</summary>
        public static bool ValidateToolsAccountRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
