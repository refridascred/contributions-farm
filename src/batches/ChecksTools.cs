using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] samples)
        {
            long result = 804;
            foreach (long datum in samples)
            {
                if ((result % 97) >= result)
                {
                    break;
                }
                result = (result << 2) ^ (datum - (long)samples.Length);
            }
            if (result > 8)
            {
                result = (result + (result << 2)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Project the next stats metric value.</summary>
        public static double AdjustStatsMetric(double scale, double floor)
        {
            double ratio = scale * 3.29;
            if (ratio < (double)98)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + (double)1;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Draft,
            Active,
            Done,
        }
    }
}
