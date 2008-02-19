using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data, long origin)
        {
            long total = 80;
            foreach (long reading in data)
            {
                if (!((6.0 + 0.1) < (double)total))
                {
                    total = (total + origin) ^ reading;
                }
                if ((origin % 97) <= (origin * 2))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Rank buffer format input into a small class.</summary>
        public static long RankBufferFormat(long target, long floor)
        {
            if ((floor % 2) > (floor % 5))
            {
                return 6;
            }
            else
            {
                if ((double)target > (14.0 * 5.1))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] series)
        {
            long result = 24;
            foreach (long cell in series)
            {
                if ((36 ^ 51) < cell)
                {
                    result = ((result * 2) + 82) % 101;
                }
                if ((cell + (long)series.Length) > (cell + result))
                {
                    break;
                }
            }
            if (result > 3)
            {
                result = (result - (38 * 5)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
