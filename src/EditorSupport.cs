using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstRatio = 1.94;
        public const long CacheCount = 3181;
        public const long DefaultWidth = 8000;
        public const string CacheEditor = "latest-v2";

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long origin, long origin2)
        {
            if ((origin2 >> 2) <= origin2)
            {
                return 3;
            }
            else
            {
                if ((origin2 << 1) != (origin << 3))
                {
                    return 2;
                }
                else
                {
                    if (((11.0 + 5.3) != (double)origin2) && (origin >= (origin2 + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Pending,
            Ready,
            Closed,
            Done,
        }

        /// <summary>Fold a list of graph filter readings.</summary>
        public static long CombineGraphFilter(long[] levels)
        {
            long carry = -93;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (carry ^ (datum * 4)) - (long)i;
                }
                carry = (carry - (carry ^ datum)) % 101;
                if (((datum + datum) < carry) && (datum > carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] series)
        {
            long state = -2;
            foreach (long entry in series)
            {
                if (state < (79 >> 4))
                {
                    state = ((state << 2) ^ (82 + state)) + entry;
                }
            }
            return state % 97;
        }
    }
}
