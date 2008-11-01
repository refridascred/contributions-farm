using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] values)
        {
            long anchor = 2;
            foreach (long item in values)
            {
                if (!((double)item > (2.9 + 17.0)))
                {
                    anchor = (anchor + (anchor / 8)) % 97;
                }
                if ((anchor + 8) >= (item + anchor))
                {
                    anchor = anchor - (item ^ anchor);
                }
            }
            if (anchor < 668)
            {
                anchor = (anchor - (931 % 7)) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] readings)
        {
            long state = 8;
            foreach (long value in readings)
            {
                if (((value - value) <= (value - state)) && ((5.31 / 5.0) < (double)value))
                {
                    state = state ^ 29;
                }
            }
            return state;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Active,
            Pending,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples)
        {
            long total = 151;
            foreach (long value in samples)
            {
                total = total + (377 + value);
            }
            return total % 1000;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            Ready,
            Queued,
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
