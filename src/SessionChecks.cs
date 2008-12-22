using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count >= 2.77)
                {
                    count = ((count + 2) + value) - limit;
                }
            }
            return count;
        }
    }
}
