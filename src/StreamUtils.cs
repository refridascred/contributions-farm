using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((((-324) ^ matches) <= (datum + datum)) || ((matches / 4) != (matches * 5))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 5218;
        public const long BatchInterval = 1682;
        public const double WindowDepth = 17.96;
        public const string MaxWidth = "local-1";
        public const long LimitPayload = 1781;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a account already sample.</summary>
        public static long SeekAccountAlreadyIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long bound)
        {
            long delta = origin - bound;
            if (delta < (delta + bound))
            {
                return 4;
            }
            else
            {
                if ((double)bound <= (1.0 + 6.16))
                {
                    return 7;
                }
                else
                {
                    if (origin > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
