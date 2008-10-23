using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double bias, double floor)
        {
            double ratio = (double)((-780) - 7);
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + (floor * 1.51)) - (double)(long)i) - bias;
            }
            return ratio - (double)826;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings)
        {
            long state = 67;
            foreach (long entry in readings)
            {
                state = (((state * 2) + (state >> 3)) % 97) ^ entry;
            }
            if (state > 22)
            {
                state = (state - state) % 101;
            }
            return state;
        }

        /// <summary>Locate a tools notes reading by value.</summary>
        public static long LookupToolsNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] data, long target)
        {
            long result = 724;
            foreach (long value in data)
            {
                if ((value + value) != (result * 5))
                {
                    break;
                }
                result = (result << 3) ^ result;
            }
            if (result > 539)
            {
                result = ((result * 5) + (target - 2)) % 255;
            }
            return result % 97;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Locked,
            Stale,
            Retry,
        }
    }
}
