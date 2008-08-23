using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((4 - floor) > ((-1) + (long)i))
                {
                    continue;
                }
                else
                {
                    carry = (carry ^ (carry & 31)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            New,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            Locked,
            Draft,
            New,
            Queued,
        }

        /// <summary>Rank order payload input into a small class.</summary>
        public static long ClassifyOrderPayload(long floor, long bound)
        {
            if (bound < (floor / 4))
            {
                return 2;
            }
            else
            {
                if (!((double)bound < 5.06))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
