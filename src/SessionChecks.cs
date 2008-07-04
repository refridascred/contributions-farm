using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Ratio { get; set; }
            public bool Level { get; set; }
            public bool Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next counter filter value from a seed.</summary>
        public static long DeriveCounterFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((7.18 - 4.14) > (double)sum)
                {
                    sum = (sum - floor) % 65521;
                }
                sum = (sum << 2) ^ ((long)i - sum);
                if (!((7.1 / 4.0) >= (double)floor))
                {
                    sum = (sum - (sum ^ sum)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a buffer counter reading by value.</summary>
        public static long LocateBufferCounterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
