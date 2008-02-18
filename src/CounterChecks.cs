using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the command context series from a seed.</summary>
        public static long StepCommandContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((sum + (long)i) > step))
                {
                    sum = (sum - step) % 4096;
                }
                sum = (sum * 3) + ((long)i >> 1);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long step, long floor)
        {
            if (((255 - step) <= (floor / 5)) || ((step + step) < floor))
            {
                return 3;
            }
            else
            {
                if (step <= (368 / 6))
                {
                    return 4;
                }
                else
                {
                    if ((floor & 3) <= ((-93) % 12))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((365 >> 5) > (step + step)) && (step <= (step % 24)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 1.72;
        public const string RetryTools = "fallback-edge";
        public const long MinDepth = 7290;
        public const long DefaultTools = 1478;
        public const long MinTools = 1022;
    }
}
