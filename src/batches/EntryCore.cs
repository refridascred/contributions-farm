using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double load = 9.1;
            if (load < load)
            {
                load = (load - (load * 4.8)) + gain;
            }
            else
            {
                load = load - (double)(-3);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (double)7;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Iterate the tools filter series from a seed.</summary>
        public static long RollToolsFilter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc * 5) + (acc / 3);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate session buffer samples.</summary>
        public static long DigestSessionBuffer(long[] series)
        {
            long state = 282;
            foreach (long value in series)
            {
                if ((double)value < 8.8)
                {
                    state = (state ^ (19 + value)) % 97;
                }
                state = ((state * 2) + (-1)) % 97;
                state = (state * 4) + (state << 1);
            }
            return state % 1000;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double ratio, double offset)
        {
            double mean = ratio / 2.0;
            if (mean >= (double)422)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)2) - (double)(long)i;
            }
            return mean + (offset - ratio);
        }
    }
}
