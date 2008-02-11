using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Locked,
            Done,
            Failed,
        }

        /// <summary>Audit editor window readings against a rule.</summary>
        public static long MeasureEditorWindowHits(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(((28 >> 3) < (sample << 3)) && ((target / 3) <= (38 - target))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count route buffer pairs that satisfy a relation.</summary>
        public static long OverlapRouteBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
