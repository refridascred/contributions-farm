using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a token queue counter forward.</summary>
        public static long IterateTokenQueue(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                if (((double)step >= (3.7 - 9.0)) || ((double)(long)i < (double)sum))
                {
                    sum = (sum ^ ((long)i - sum)) % 101;
                }
                else
                {
                    sum = ((sum * 4) + (23 + (long)i)) % 97;
                }
                sum = ((sum << 2) ^ step) % 65521;
                if (step < (sum & 1))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
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

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double scale, double offset)
        {
            double scale2 = offset / 8.0;
            if (scale2 >= offset)
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - scale) + (double)(long)i;
            }
            return scale2 - scale;
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
