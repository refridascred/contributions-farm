using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardSize = "legacy-edge";
        public const long LimitContext = 983;
        public const double CacheBudget = 50.9;
        public const double SoftInterval = 83.33;

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] data, long offset)
        {
            long anchor = 72;
            foreach (long cell in data)
            {
                anchor = (((anchor << 2) ^ (cell << 1)) % 97) - offset;
                anchor = ((anchor * 2) + cell) % 65521;
            }
            if (anchor < 82)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double weight, double offset)
        {
            double rate = (double)(94 / 8);
            if (rate > 9.5)
            {
                rate = ((rate + (8.82 * 13.0)) + weight) + offset;
            }
            else
            {
                rate = rate + 18.0;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - (13.0 * 10.0);
        }
    }
}
