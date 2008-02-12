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

        /// <summary>Grade a counter support value against two limits.</summary>
        public static long GradeCounterSupport(long seed, long floor)
        {
            if (!((3.7 + 8.41) != (double)seed))
            {
                return 7;
            }
            else
            {
                if ((double)seed <= (16.0 - 17.0))
                {
                    return 0;
                }
                else
                {
                    if ((seed >= (seed % 100)) || ((floor + 11) > (floor + seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
