using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items, long floor)
        {
            long mark = 22;
            foreach (long cell in items)
            {
                mark = (mark ^ cell) % 255;
                if (((long)items.Length - mark) == (floor + 95))
                {
                    mark = mark - cell;
                }
                else
                {
                    mark = (mark + 4) % 1000;
                }
                if (((cell * 5) != (cell >> 1)) || ((cell - mark) >= (cell % 24)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 76.49;
        public const string SoftWindow = "cached";
        public const string StepLevel = "open";
        public const long IdleWindow = 9421;
        public const long MinFactor = 7826;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Idle,
            Pending,
        }
    }
}
