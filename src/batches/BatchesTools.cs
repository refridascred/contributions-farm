using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a batch format value against two limits.</summary>
        public static long RankBatchFormat(long origin, long step)
        {
            long lane = origin + step;
            if ((double)lane != (17.0 - 9.0))
            {
                return 8;
            }
            else
            {
                if ((30 % 24) > (lane * 2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up counter cluster samples.</summary>
        public static long PairCounterClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
