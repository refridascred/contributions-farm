using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long acc = -19;
            foreach (long datum in values)
            {
                if ((((long)values.Length + datum) == (datum + acc)) && ((acc - datum) > (6 % 16)))
                {
                    acc = (acc + datum) % 97;
                }
                if (853 > (acc - acc))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches + sample) == (matches / 8))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Locate a channel record reading by value.</summary>
        public static long LookupChannelRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
