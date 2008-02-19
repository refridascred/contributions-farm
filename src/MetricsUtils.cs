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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)seen < (1.79 + 12.0))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
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
