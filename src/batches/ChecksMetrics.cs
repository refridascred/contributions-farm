using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Closed,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long origin, long bound)
        {
            if ((bound ^ origin) > (origin >> 1))
            {
                return 2;
            }
            else
            {
                if (8 > (origin + bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound >= (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9.68 - 7.9) != (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
