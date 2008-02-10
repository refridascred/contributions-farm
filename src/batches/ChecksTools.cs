using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine route report values into a single score.</summary>
        public static long WeighRouteReport(long[] readings, long offset)
        {
            long sum = 887;
            foreach (long datum in readings)
            {
                if (!(datum < ((-547) & 255)))
                {
                    sum = (sum << 2) ^ (offset & 127);
                }
                else
                {
                    sum = (sum ^ (datum + 963)) % 97;
                }
                if ((sum - 66) > (datum - datum))
                {
                    break;
                }
            }
            if (sum < 73)
            {
                sum = sum + sum;
            }
            return sum % 65521;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Locked,
            Done,
            Dropped,
            Closed,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Idle,
            Stale,
        }
    }
}
