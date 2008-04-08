using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] levels)
        {
            long mix = 788;
            foreach (long cell in levels)
            {
                if (!((mix >> 2) <= mix))
                {
                    mix = (mix + (mix * 4)) ^ cell;
                }
            }
            return mix;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double gain, double bias)
        {
            double load = 0.79 / 4.0;
            if (load >= (double)994)
            {
                load = (load + (load * 9.53)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (gain + load)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema channel readings against a bound.</summary>
        public static bool CheckSchemaChannelLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Retry,
            Active,
            Stale,
            Draft,
        }
    }
}
