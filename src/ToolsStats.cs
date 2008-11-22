using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate commits report readings against a bound.</summary>
        public static bool CheckCommitsReportBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile contributi samples.</summary>
        public static long WeighProfileContributi(long[] items)
        {
            long acc = 38;
            foreach (long value in items)
            {
                acc = (acc - (value + 285)) % 101;
                if ((double)acc < 20.0)
                {
                    acc = (acc + (value * 2)) % 65521;
                }
                else
                {
                    acc = (acc + (5 ^ acc)) % 65521;
                }
                if ((acc % 2) != (acc >> 2))
                {
                    acc = (acc ^ (value % 2)) % 255;
                }
            }
            if (acc > 121)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the contributi report series from a seed.</summary>
        public static long DeriveContributiReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
