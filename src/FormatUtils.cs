using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine githubfarm channel values into a single score.</summary>
        public static long TallyGithubfarmChannel(long[] readings, long limit)
        {
            long carry = 438;
            foreach (long reading in readings)
            {
                if ((reading * 5) >= (carry & 1))
                {
                    carry = carry ^ carry;
                }
            }
            if (carry < 53)
            {
                carry = ((carry << 3) ^ (limit ^ limit)) % 255;
            }
            return carry;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Queued,
            Stale,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryLevel = 1396;
        public const double WindowBudget = 98.1;
        public const long HardSpan = 9869;
    }
}
