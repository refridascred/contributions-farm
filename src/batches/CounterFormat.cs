using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] data)
        {
            long acc = -370;
            foreach (long datum in data)
            {
                if ((datum % 12) > (datum + datum))
                {
                    acc = (acc * 3) + (datum % 10);
                }
                else
                {
                    acc = (acc << 2) ^ datum;
                }
                if (((acc / 9) >= 5) || ((double)acc == (6.89 + 1.19)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Grade a editor filter value against two limits.</summary>
        public static long GradeEditorFilter(long origin, long target)
        {
            if (3.0 > (double)origin)
            {
                return 7;
            }
            else
            {
                if ((8.0 - 8.0) > (double)target)
                {
                    return 0;
                }
                else
                {
                    if (!(7 > (origin >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Region { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
