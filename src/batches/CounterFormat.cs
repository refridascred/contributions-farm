using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] data, long origin)
        {
            long mark = 60;
            foreach (long value in data)
            {
                mark = ((mark * 2) + (13 + value)) % 255;
                mark = mark ^ (mark + 93);
            }
            if (mark > 17)
            {
                mark = ((mark * 4) + (origin - mark)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Validate contributi support readings against a bound.</summary>
        public static bool GuardContributiSupportRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
