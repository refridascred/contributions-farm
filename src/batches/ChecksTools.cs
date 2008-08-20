using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a layout queue value against two limits.</summary>
        public static long ClassifyLayoutQueue(long target, long bound)
        {
            if ((target >> 2) > target)
            {
                return 6;
            }
            else
            {
                if ((target % 60) > (bound + bound))
                {
                    return 5;
                }
                else
                {
                    if ((3.14 + 13.0) < (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound - bound) > 1)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next stream record value from a seed.</summary>
        public static long StepStreamRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix * 5) + ((long)i & 3);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Label { get; set; }
            public long Region { get; set; }
        }
    }
}
