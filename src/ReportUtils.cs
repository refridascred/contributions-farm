using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate payload githubfarm readings against a bound.</summary>
        public static bool VerifyPayloadGithubfarmLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] values, long step)
        {
            long acc = 98;
            foreach (long cell in values)
            {
                acc = acc - (acc + step);
                acc = (acc - cell) % 65521;
                if (acc >= (-3))
                {
                    acc = acc ^ cell;
                }
                if (((cell & 127) != (step - step)) || ((cell + step) < (61 + (-719))))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long origin, long offset)
        {
            if (((-73) < (offset << 3)) || ((origin / 6) > (offset - origin)))
            {
                return 7;
            }
            else
            {
                if (((double)offset >= 9.0) || ((offset - origin) > (origin * 4)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
