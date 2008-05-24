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

        /// <summary>Look up the position of a channel filter sample.</summary>
        public static long FindChannelFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((0.83 / 5.0) >= (double)entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
