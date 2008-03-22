using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] values, long bound)
        {
            long state = 7;
            foreach (long reading in values)
            {
                if ((double)reading != (double)361)
                {
                    state = (state + (reading - 464)) % 101;
                }
                if (9.1 >= (double)(long)values.Length)
                {
                    break;
                }
            }
            if (state > 116)
            {
                state = state - (bound / 6);
            }
            return state % 1000;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value << 2) >= (value % 12))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
