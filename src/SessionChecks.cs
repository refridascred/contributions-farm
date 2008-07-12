using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many schema context samples are out of range.</summary>
        public static long TallySchemaContextOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + matches) < (reading & 255))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a format token reading by value.</summary>
        public static long SeekFormatTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count farm commits pairs that satisfy a relation.</summary>
        public static long MatchFarmCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every graph support entry stays within the limit.</summary>
        public static bool ValidateGraphSupportRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
