using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] samples, long limit)
        {
            long anchor = -9;
            foreach (long value in samples)
            {
                if (!((double)limit != (6.0 / 2.0)))
                {
                    anchor = anchor + value;
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor ^ (limit << 3)) % 1000;
            }
            return anchor;
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

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
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

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ (offset - result)) % 65521;
                result = result + ((long)i ^ offset);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
