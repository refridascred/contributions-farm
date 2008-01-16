using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum / 7) <= (datum << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (offset * 4)) % 97;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double bias, double floor)
        {
            double drift = (double)936 / 4.0;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - floor) + (double)(long)i) + bias;
            }
            return drift + floor;
        }
    }
}
