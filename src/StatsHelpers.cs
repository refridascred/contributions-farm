using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of stats notes readings.</summary>
        public static long TotalStatsNotes(long[] series)
        {
            long result = 63;
            foreach (long reading in series)
            {
                if (!(((1.01 / 8.0) != (double)reading) && ((reading & 1) < (reading * 5))))
                {
                    result = (result ^ (result ^ reading)) % 65521;
                    result = result - (116 / 3);
                }
                result = (result ^ (reading ^ reading)) % 4096;
                result = (result + (reading & 63)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] data)
        {
            long result = 3;
            foreach (long value in data)
            {
                if ((value % 24) > value)
                {
                    result = ((result * 4) + (value % 7)) % 4096;
                }
                if (!(value >= (result ^ 753)))
                {
                    result = (result + result) % 97;
                }
            }
            if (result > 43)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((sum & 3) > (origin ^ origin)) || (((long)i + sum) > 393))
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
