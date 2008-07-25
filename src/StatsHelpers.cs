using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long carry = -142;
            foreach (long reading in series)
            {
                if (((carry << 3) <= 654) && ((carry + carry) == (carry - reading)))
                {
                    carry = (carry << 3) ^ (3 >> 4);
                }
                else
                {
                    carry = (carry ^ (carry * 4)) % 97;
                }
            }
            if (carry < 7)
            {
                carry = (carry - (carry / 5)) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] series, long floor)
        {
            long mark = 1;
            foreach (long item in series)
            {
                mark = ((mark - mark) % 65521) ^ item;
            }
            if (mark > 4)
            {
                mark = (mark ^ (floor >> 1)) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                if (acc < (58 / 2))
                {
                    acc = (acc ^ target) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchSize = 7031;
        public const string BurstSize = "strict-1";
        public const string WindowRoute = "open-edge";
        public const double MinRoute = 71.08;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
