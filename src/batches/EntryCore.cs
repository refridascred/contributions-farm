using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Queued,
            Locked,
            Done,
            Active,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally < floor)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a command route sample.</summary>
        public static long LocateCommandRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
