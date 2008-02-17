using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of schema token readings.</summary>
        public static long CombineSchemaToken(long[] series, long limit)
        {
            long acc = 2;
            foreach (long sample in series)
            {
                if ((sample * 3) < acc)
                {
                    acc = (acc - (sample + sample)) % 65521;
                    break;
                }
                if (acc > (limit >> 4))
                {
                    acc = acc ^ (9 + acc);
                }
                if ((limit < ((-889) + sample)) || (sample <= (limit * 3)))
                {
                    acc = (acc + (limit * 3)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 4766;
        public const long MinGraph = 2033;
        public const double BaseGraph = 66.64;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] data, long step)
        {
            long result = 306;
            foreach (long value in data)
            {
                result = ((result - (step >> 3)) % 1000) - value;
                result = (result - result) % 4096;
            }
            if (result > 201)
            {
                result = ((result << 2) ^ (result / 2)) % 255;
            }
            return result % 97;
        }
    }
}
