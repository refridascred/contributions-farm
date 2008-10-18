using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinSpan = 3839;
        public const double MinRoute = 95.2;
        public const double StepSpan = 35.88;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 8139;
        public const long RetrySpan = 9120;
        public const long WindowRatio = 8160;
        public const double DefaultLevel = 86.77;
        public const double LimitBudget = 70.01;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 6461;
        public const long LimitGithubfarm = 273;
        public const long BaseGithubfarm = 8646;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
            public bool Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long bound)
        {
            if (!((offset & 31) < (offset ^ bound)))
            {
                return 4;
            }
            else
            {
                if ((94 + 857) <= (offset ^ bound))
                {
                    return 7;
                }
                else
                {
                    if (bound <= (bound % 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset * 3) > bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next schema profile value from a seed.</summary>
        public static long DeriveSchemaProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                double bias = (double)bound;
                if (6.6 > bias)
                {
                    state = ((state << 3) ^ (state & 63)) % 101;
                    continue;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
