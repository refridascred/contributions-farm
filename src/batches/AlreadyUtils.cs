using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a record payload reading by value.</summary>
        public static long LookupRecordPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next editor profile value.</summary>
        public static double ProjectEditorProfile(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > 6.85)
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (4.08 + 8.7)) + (double)(long)i;
            }
            return scale - (bias2 * 3.84);
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long step, long step2)
        {
            if ((double)step2 == (3.3 - 2.06))
            {
                return 1;
            }
            else
            {
                if ((step2 - step2) < (862 & 127))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
