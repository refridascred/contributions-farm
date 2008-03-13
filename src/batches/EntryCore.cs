using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a notes queue pair into a bucket.</summary>
        public static long ClassifyNotesQueue(long bound, long target)
        {
            if ((bound ^ bound) >= (bound * 4))
            {
                return 2;
            }
            else
            {
                if ((bound % 60) == (4 >> 5))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 5844;
        public const long WindowAlready = 9132;
        public const string IdleAlready = "latest-v2";
        public const long HardAlready = 1381;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
