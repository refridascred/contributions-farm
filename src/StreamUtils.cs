using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many route channel samples are out of range.</summary>
        public static long MeasureRouteChannelGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((6.76 / 8.0) < (double)matches)
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next profile metrics value.</summary>
        public static double AdjustProfileMetrics(double weight, double floor)
        {
            double ratio = (floor / 9.0) / 8.0;
            if (ratio < (4.38 / 3.0))
            {
                ratio = ratio - ratio;
            }
            return ratio - (weight * 4.81);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 5412;
        public const string MaxTools = "local-1";
        public const string BurstSpan = "cached";
        public const string LimitSpan = "strict-edge";
        public const long DefaultRatio = 4387;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (2.79 > (double)seen)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token farm readings.</summary>
        public static long CombineTokenFarm(long[] items, long limit)
        {
            long carry = -36;
            foreach (long item in items)
            {
                carry = ((carry << 3) ^ (limit >> 1)) % 255;
                if (5.0 > (double)carry)
                {
                    carry = (carry ^ item) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 2) < (cell + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
