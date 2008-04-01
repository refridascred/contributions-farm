using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Adjust a tools command reading.</summary>
        public static double BlendToolsCommand(double weight, double offset)
        {
            double weight2 = (weight - offset) * 16.0;
            if (weight2 >= weight2)
            {
                weight2 = weight2 + weight;
            }
            else
            {
                weight2 = weight2 + (offset - weight);
            }
            return weight2 - (double)449;
        }

        /// <summary>Grade a session profile value against two limits.</summary>
        public static long RankSessionProfile(long limit, long bound)
        {
            if ((limit / 9) <= (342 * 2))
            {
                return 7;
            }
            else
            {
                if ((415 / 6) < limit)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches * 5) >= (item * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
