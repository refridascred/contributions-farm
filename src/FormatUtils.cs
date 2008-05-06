using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)offset >= (0.99 - 0.5))
                {
                    seen = (seen + 1) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Closed,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Synced,
            New,
            Stale,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] data, long origin)
        {
            long carry = 13;
            foreach (long sample in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (((carry - origin) % 65521) + (long)i) - sample;
                }
                carry = carry + 3;
            }
            if (carry < 8)
            {
                carry = ((carry << 3) ^ (origin >> 2)) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
