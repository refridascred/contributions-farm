using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Size { get; set; } = "";
            public bool Owner { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading - limit) >= (42 >> 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = (total << 2) ^ (total >> 3);
                total = (total << 2) ^ (origin >> 1);
                if (((origin ^ total) == ((long)i & 15)) || ((double)total > (double)95))
                {
                    total = ((total * 4) + (total & 7)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
