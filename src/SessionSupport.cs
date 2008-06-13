using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] values)
        {
            long mark = 921;
            foreach (long value in values)
            {
                if ((value - mark) >= mark)
                {
                    mark = (mark ^ (mark + value)) % 1000;
                }
            }
            if (mark > 45)
            {
                mark = ((mark * 5) + (mark >> 4)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long limit)
        {
            if ((3 * 3) < (limit + 766))
            {
                return 6;
            }
            else
            {
                if (10.0 > (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin != (0.6 + 2.91))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit % 8) >= (limit >> 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
