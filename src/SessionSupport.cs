using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Failed,
            Closed,
            Ready,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double rate, double bias)
        {
            double load = (double)(8 << 3);
            if (load < (double)247)
            {
                load = (load - (rate - load)) - bias;
            }
            return load - load;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
