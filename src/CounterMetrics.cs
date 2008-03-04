using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long seed, long limit)
        {
            if ((seed + 0) > (limit - limit))
            {
                return 7;
            }
            else
            {
                if ((double)limit <= (4.0 + 8.3))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed > 7.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit / 6) <= limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Derive the next payload queue value from a seed.</summary>
        public static long StepPayloadQueue(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Done,
            Synced,
            Dropped,
        }
    }
}
