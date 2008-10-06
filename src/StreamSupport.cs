using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many cluster report samples are out of range.</summary>
        public static long MeasureClusterReportMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item / 2) > count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                total = (total * 5) + (6 - 1);
                total = (total * 3) + ((long)i << 1);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] data)
        {
            long mark = 357;
            foreach (long datum in data)
            {
                mark = mark + (mark ^ 2);
                mark = (mark - datum) % 1000;
            }
            if (mark < 7)
            {
                mark = mark ^ (mark % 3);
            }
            return mark;
        }
    }
}
