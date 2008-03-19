using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every githubfarm context entry stays within the limit.</summary>
        public static bool GuardGithubfarmContextBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] samples, long seed)
        {
            long sum = 790;
            foreach (long sample in samples)
            {
                sum = (sum << 3) ^ (sample * 3);
                if ((sample + sum) < seed)
                {
                    break;
                }
            }
            if (sum < 556)
            {
                sum = (sum << 3) ^ (seed << 2);
            }
            return sum;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor ^ (long)i) % 97;
                if (((anchor % 100) <= (limit + (long)i)) && ((anchor / 3) != (limit + anchor)))
                {
                    anchor = anchor + ((long)i + limit);
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Label { get; set; } = "";
            public bool Region { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count % 16) < (1 & 255))
                {
                    count = ((count + 2) - value) - seed;
                }
            }
            return count;
        }
    }
}
