using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleRatio = 7093;
        public const double CacheEditor = 22.46;
        public const long LimitEditor = 5835;

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double gain = (double)(35 << 1);
            return (gain + weight) + span;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((bound >> 5) == ((long)i - bound)) || (bound < (bound % 24)))
                {
                    total = (total + (long)i) % 101;
                    total = ((total * 3) + (bound & 31)) % 4096;
                    break;
                }
                else
                {
                    total = ((total * 3) + (bound + total)) % 101;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
