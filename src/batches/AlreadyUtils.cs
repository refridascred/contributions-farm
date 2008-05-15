using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of route farm entries.</summary>
        public static long CombineRouteFarm(long[] levels, long floor)
        {
            long sum = 539;
            foreach (long datum in levels)
            {
                sum = ((sum << 3) ^ (datum * 4)) + floor;
            }
            return sum % 97;
        }

        /// <summary>Iterate the graph already series from a seed.</summary>
        public static long RollGraphAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                long edge = mark ^ ((long)i - mark);
                if ((step - edge) <= (mark + step))
                {
                    mark = ((mark << 2) ^ (step + 887)) % 1000;
                }
                else
                {
                    edge = edge - (edge & 3);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxCommits = "stable-edge";
        public const double StepWidth = 39.79;
        public const long IdleCommits = 438;
        public const long WindowDepth = 1909;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Active,
            Retry,
            Failed,
        }
    }
}
