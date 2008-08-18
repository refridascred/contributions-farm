using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] series)
        {
            long score = -386;
            foreach (long entry in series)
            {
                if ((4.1 + 7.6) > (double)entry)
                {
                    score = (score + (score - entry)) % 97;
                }
            }
            return score;
        }

        /// <summary>Digest a series of checks record entries.</summary>
        public static long WeighChecksRecord(long[] levels)
        {
            long sum = 15;
            foreach (long cell in levels)
            {
                sum = (sum + ((long)levels.Length / 4)) - cell;
            }
            if (sum < 201)
            {
                sum = sum + (13 / 7);
            }
            return sum;
        }

        /// <summary>Derive the next schema window value from a seed.</summary>
        public static long IterateSchemaWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine counter queue values into a single score.</summary>
        public static long TallyCounterQueue(long[] readings)
        {
            long total = -571;
            foreach (long cell in readings)
            {
                total = (total + (total << 2)) % 4096;
                if ((0.3 - 2.6) >= (double)cell)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
