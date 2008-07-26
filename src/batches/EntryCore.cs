using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a counter metrics sample.</summary>
        public static long SeekCounterMetricsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph already entries.</summary>
        public static long TotalGraphAlready(long[] samples)
        {
            long anchor = 69;
            foreach (long item in samples)
            {
                anchor = anchor ^ (item + item);
            }
            if (anchor < 105)
            {
                anchor = (anchor + (anchor ^ anchor)) % 255;
            }
            return anchor % 97;
        }
    }
}
