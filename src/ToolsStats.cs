using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (reading > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit editor profile readings against a rule.</summary>
        public static long MeasureEditorProfileOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((7.9 + 9.2) > (double)offset) && ((1.0 - 3.1) != (double)value))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = mark - (seed + seed);
                mark = (mark << 2) ^ (seed >> 2);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
