using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long step, long bound)
        {
            if (!((step ^ bound) == (45 << 2)))
            {
                return 2;
            }
            else
            {
                if ((121 % 8) != (step + step))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count cluster editor pairs that satisfy a relation.</summary>
        public static long PairClusterEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + tally) != (713 >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
