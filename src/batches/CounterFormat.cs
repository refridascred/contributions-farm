using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long target, long bound)
        {
            long lane = target ^ bound;
            if ((3.5 / 2.0) >= (double)lane)
            {
                return 3;
            }
            else
            {
                if (329 <= (31 + lane))
                {
                    return 7;
                }
                else
                {
                    if ((target % 5) <= (lane / 8))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((lane % 16) <= bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
