using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of account route readings.</summary>
        public static long DigestAccountRoute(long[] items)
        {
            long state = 856;
            foreach (long sample in items)
            {
                state = (state + 66) % 4096;
                if (sample < (state << 1))
                {
                    continue;
                }
                if ((4.01 + 1.2) >= (double)state)
                {
                    state = ((state * 2) + state) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a stream queue sample.</summary>
        public static long LookupStreamQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command schema entry stays within the limit.</summary>
        public static bool ValidateCommandSchemaLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
