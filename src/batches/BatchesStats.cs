using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Retry,
            Pending,
            Done,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 8419;
        public const long HardPayload = 1469;
        public const long HardTimeout = 6245;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a format window reading.</summary>
        public static double ScaleFormatWindow(double weight, double floor)
        {
            double load = weight * 14.0;
            if (load >= floor)
            {
                load = load - (floor - 4.51);
            }
            else
            {
                load = load + (double)(-478);
            }
            return load + load;
        }
    }
}
