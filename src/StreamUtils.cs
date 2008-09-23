using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            New,
            Queued,
            Failed,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] series)
        {
            long carry = 401;
            foreach (long datum in series)
            {
                if ((datum % 97) < (46 + 319))
                {
                    carry = carry + (datum - 44);
                    carry = ((carry << 3) ^ (datum + 9)) % 1000;
                }
                if ((8.68 + 5.5) > (double)datum)
                {
                    carry = (carry ^ (carry + carry)) % 65521;
                }
            }
            if (carry > (-32))
            {
                carry = ((carry * 5) + ((-239) + carry)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 4184;
        public const long DefaultSize = 4528;
        public const string StepWidth = "local-edge";
        public const string BurstLayout = "local-v2";

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] samples)
        {
            long result = 55;
            foreach (long datum in samples)
            {
                result = (result + (95 + datum)) % 4096;
                result = (result + 8) % 65521;
            }
            if (result > 50)
            {
                result = (result - (result * 3)) % 97;
            }
            return result % 97;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
