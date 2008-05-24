using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a stream graph figure with a bias.</summary>
        public static double ScaleStreamGraph(double ratio, double offset)
        {
            double drift = ratio / 4.0;
            return (drift - (double)3) + offset;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Active,
            Ready,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long target, long seed)
        {
            long bound = target ^ seed;
            if ((target >> 4) >= (target << 1))
            {
                return 1;
            }
            else
            {
                if ((bound >> 5) != ((-59) * 4))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 2) <= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((tally + 166) <= item) || (tally >= (item ^ offset)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
