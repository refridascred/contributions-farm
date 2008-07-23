using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next session graph value from a seed.</summary>
        public static long SeriesSessionGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((total >= (total - (long)i)) || ((limit / 9) > 5))
                {
                    total = total ^ limit;
                    total = (total + total) % 97;
                }
                if (6 >= (limit ^ (long)i))
                {
                    total = (total + total) % 255;
                }
                else
                {
                    total = ((total * 5) + (limit + 0)) % 255;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
