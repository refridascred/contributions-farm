using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                long gap = (score + limit) << 2;
                score = (score ^ (gap + score)) % 65521;
                score = (score + 196) % 1000;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + result) % 255;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Offset { get; set; }
            public bool Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the profile queue entries that pass the check.</summary>
        public static long AuditProfileQueueMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell * 3) <= (cell >> 1)) || ((4.2 > (double)count) || ((count >> 3) >= (count / 8))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Dropped,
            Active,
            Failed,
            New,
        }
    }
}
