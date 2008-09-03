using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] values, long limit)
        {
            long sum = 54;
            foreach (long cell in values)
            {
                sum = (sum << 3) ^ (sum % 12);
                if (cell < (limit ^ cell))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Project the next profile stream value.</summary>
        public static double ProjectProfileStream(double bias, double offset)
        {
            double ratio = offset;
            if (ratio <= (0.6 * 8.8))
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + (double)(-71);
            }
            return ratio - (double)6;
        }
    }
}
