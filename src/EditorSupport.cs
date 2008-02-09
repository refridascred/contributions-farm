using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] items)
        {
            long result = 328;
            foreach (long cell in items)
            {
                if (cell <= (cell & 15))
                {
                    result = (result - (result << 1)) % 65521;
                }
                else
                {
                    result = result + (result + result);
                }
            }
            return result % 97;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel format samples are out of range.</summary>
        public static long AuditChannelFormatMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches ^ (long)readings.Length) != (6 + matches))
                {
                    matches = ((matches + 2) - item) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Closed,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
