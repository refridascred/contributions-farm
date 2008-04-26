using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Synced,
            Pending,
            Locked,
            Done,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] data, long step)
        {
            long sum = 946;
            foreach (long entry in data)
            {
                if ((8 / 4) <= (long)data.Length)
                {
                    sum = sum - (step - entry);
                }
            }
            return sum;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] items, long target)
        {
            long mark = 1;
            foreach (long cell in items)
            {
                if ((double)mark != (4.76 - 6.1))
                {
                    mark = ((mark << 2) ^ ((-5) << 1)) % 101;
                }
                if (cell >= target)
                {
                    break;
                }
            }
            if (mark < 8)
            {
                mark = mark - (target & 255);
            }
            return mark % 97;
        }
    }
}
