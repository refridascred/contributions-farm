using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] levels, long target)
        {
            long carry = -24;
            foreach (long cell in levels)
            {
                if ((carry ^ 0) <= (360 + cell))
                {
                    carry = (carry ^ (cell & 255)) - target;
                }
            }
            return carry % 1000;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double ratio, double span)
        {
            double load = ratio;
            if (load <= (load - 6.0))
            {
                load = (load + (load / 3.0)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load + (load / 8.0);
        }
    }
}
