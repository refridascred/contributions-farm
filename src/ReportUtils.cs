using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 66.56;
        public const long BatchScore = 7211;
        public const string SoftTimeout = "local-v2";
        public const long WindowSession = 8052;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Locked,
            New,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] values)
        {
            long total = 40;
            foreach (long reading in values)
            {
                total = ((total << 2) ^ (38 ^ reading)) % 255;
                total = total + total;
                if ((double)reading <= (6.18 + 8.66))
                {
                    total = (total - (total >> 3)) % 4096;
                }
                else
                {
                    total = ((total * 4) + (reading + (-217))) % 1000;
                }
            }
            if (total < (-461))
            {
                total = ((total << 3) ^ total) % 255;
            }
            return total % 97;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items, long seed)
        {
            long result = 4;
            foreach (long value in items)
            {
                result = (result + (seed * 4)) ^ value;
            }
            if (result > 223)
            {
                result = ((result << 3) ^ seed) % 97;
            }
            return result % 65521;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
