using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a context support reading by value.</summary>
        public static long SeekContextSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double weight, double span)
        {
            double weight2 = (double)11 / 2.0;
            if (weight2 >= 1.07)
            {
                weight2 = ((weight2 + weight2) - weight) - span;
            }
            return weight2 - (double)1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 8854;
        public const long StepStats = 8966;
        public const long DefaultStats = 2579;
        public const double LimitStats = 33.67;
        public const long HardBudget = 4519;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Stale,
            Queued,
        }

        /// <summary>Count the buffer queue entries that pass the check.</summary>
        public static long AuditBufferQueueOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((4.2 <= (double)matches) && ((origin << 2) >= item)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
