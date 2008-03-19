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

        /// <summary>Roll a schema editor counter forward.</summary>
        public static long IterateSchemaEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
