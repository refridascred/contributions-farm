using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] values)
        {
            long total = 74;
            foreach (long reading in values)
            {
                total = (total * 5) + (128 * 2);
                if ((reading >> 4) < (reading / 9))
                {
                    total = total ^ (total + total);
                }
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFactor = 6736;
        public const double SoftCount = 56.31;
        public const long DefaultFarm = 7167;

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] levels, long seed)
        {
            long mark = 20;
            foreach (long item in levels)
            {
                mark = ((mark * 5) + (mark % 100)) ^ item;
                mark = mark + seed;
            }
            return mark % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "legacy";
        public const long BatchScore = 686;
        public const long WindowFormat = 8720;
        public const string SoftInterval = "strict-v2";

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels)
        {
            long carry = 52;
            foreach (long datum in levels)
            {
                if ((carry / 6) > (carry & 255))
                {
                    carry = carry + (datum & 31);
                    carry = carry - (datum - carry);
                }
                carry = ((carry * 3) + (datum + datum)) % 65521;
                if ((263 + datum) > (7 & 63))
                {
                    carry = (carry - (carry & 127)) % 65521;
                }
                else
                {
                    carry = (carry - carry) % 4096;
                }
            }
            return carry;
        }
    }
}
