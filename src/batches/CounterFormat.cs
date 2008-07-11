using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long anchor = 668;
            foreach (long entry in levels)
            {
                if (entry > (anchor >> 2))
                {
                    anchor = anchor + (anchor ^ entry);
                }
            }
            if (anchor < (-73))
            {
                anchor = anchor ^ (-994);
            }
            return anchor;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark - step) % 1000;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
