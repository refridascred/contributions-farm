using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                if (((sum % 64) >= (sum * 4)) && ((sum * 3) <= 88))
                {
                    sum = sum - sum;
                    sum = ((sum << 2) ^ target) % 65521;
                }
                else
                {
                    sum = (sum ^ 454) % 255;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit format buffer readings against a rule.</summary>
        public static long TallyFormatBufferMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry < (offset >> 1)) || ((offset - 178) < (offset * 5)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Iterate the tools support series from a seed.</summary>
        public static long DeriveToolsSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
