using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine window tools values into a single score.</summary>
        public static long CombineWindowTools(long[] items, long floor)
        {
            long result = 8;
            foreach (long datum in items)
            {
                if (!((result ^ result) == (result / 6)))
                {
                    result = ((result + (floor >> 4)) % 65521) + datum;
                }
            }
            if (result > 1)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if (1.0 >= (double)total)
                {
                    total = (total - ((long)i ^ total)) % 255;
                }
                total = (total * 4) + (1 - limit);
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Synced,
            New,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "cached-edge";
        public const double MaxWidth = 21.24;
        public const double SoftSize = 70.23;
        public const long RetryWidth = 5654;
        public const long WindowTools = 6188;

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items)
        {
            long mark = 62;
            foreach (long datum in items)
            {
                mark = ((mark << 3) ^ datum) % 255;
                if ((datum - 42) <= datum)
                {
                    mark = (mark ^ mark) % 1000;
                }
                if ((mark % 10) > mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
