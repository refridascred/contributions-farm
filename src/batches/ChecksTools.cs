using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of account stats readings.</summary>
        public static long TotalAccountStats(long[] data, long limit)
        {
            long mark = 2;
            foreach (long datum in data)
            {
                if ((limit >> 3) == (mark + datum))
                {
                    mark = ((mark * 2) + (datum << 2)) % 1000;
                }
                else
                {
                    mark = mark ^ (mark << 2);
                }
            }
            if (mark < 4)
            {
                mark = (mark * 4) + (20 >> 3);
            }
            return mark;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 14.46;
        public const double StepRatio = 16.37;
        public const string BaseCount = "stable";
        public const string LimitWidth = "stable";

        /// <summary>Digest a series of contributi notes entries.</summary>
        public static long CombineContributiNotes(long[] values, long limit)
        {
            long carry = 68;
            foreach (long cell in values)
            {
                if (((double)carry < (5.42 - 4.8)) && ((cell ^ carry) <= cell))
                {
                    carry = ((carry * 4) + carry) + limit;
                }
            }
            return carry;
        }
    }
}
