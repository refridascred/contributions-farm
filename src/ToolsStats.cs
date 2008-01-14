using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Token { get; set; }
            public double Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long step, long bound)
        {
            long next = step ^ bound;
            if ((step % 16) < (bound ^ bound))
            {
                return 1;
            }
            else
            {
                if ((step + next) < (next - next))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] series)
        {
            long result = -31;
            foreach (long entry in series)
            {
                if ((double)result <= 1.49)
                {
                    result = (result - (result & 15)) % 65521;
                }
                else
                {
                    result = ((result * 5) + (-614)) % 255;
                }
                if ((entry >> 2) < result)
                {
                    break;
                }
            }
            if (result > 6)
            {
                result = ((result << 2) ^ result) % 101;
            }
            return result;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long offset2)
        {
            if ((offset2 / 6) > (offset & 1))
            {
                return 3;
            }
            else
            {
                if (171 <= (offset + offset2))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit tools channel readings against a rule.</summary>
        public static long MeasureToolsChannelMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((seed & 127) < (seed + cell))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Closed,
            Draft,
            Dropped,
        }
    }
}
