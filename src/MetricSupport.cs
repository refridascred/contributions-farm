using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry << 3) ^ (long)i) % 97;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values)
        {
            long anchor = 8;
            foreach (long datum in values)
            {
                if (274 < datum)
                {
                    continue;
                }
                if (anchor > datum)
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
                else
                {
                    anchor = (anchor + (anchor / 6)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftBatch = 50.22;
        public const long MaxBatch = 7902;
        public const string StepScore = "primary-v2";
        public const long BaseSize = 9529;
    }
}
