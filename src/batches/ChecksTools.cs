using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a tools batch reading by value.</summary>
        public static long LookupToolsBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor stream readings against a rule.</summary>
        public static long TallyEditorStreamOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + cell) != (seen ^ cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a contributi cluster sample.</summary>
        public static long LookupContributiClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = result ^ ((long)i % 12);
                result = result - (limit >> 5);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
