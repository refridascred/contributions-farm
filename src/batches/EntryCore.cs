using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Derive the next stats buffer value from a seed.</summary>
        public static long RollStatsBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (-3)) % 255;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long offset, long origin)
        {
            long bound = offset ^ origin;
            if ((8.8 / 9.0) == (double)bound)
            {
                return 6;
            }
            else
            {
                if (((5.6 * 0.26) != (double)bound) || ((offset * 4) > (offset - 63)))
                {
                    return 7;
                }
                else
                {
                    if ((18.0 - 9.0) >= (8.0 + 1.85))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
