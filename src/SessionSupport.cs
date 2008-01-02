using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((2.1 + 2.7) > (double)(long)i) || ((long)i >= (mix >> 4)))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
