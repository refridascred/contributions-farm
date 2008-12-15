using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long seed, long bound)
        {
            if ((double)bound > 6.7)
            {
                return 3;
            }
            else
            {
                if ((seed - 37) < (bound / 6))
                {
                    return 8;
                }
                else
                {
                    if (!((seed + bound) < bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((13.0 - 0.7) > (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Failed,
            Done,
            Ready,
        }
    }
}
