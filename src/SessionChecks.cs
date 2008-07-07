using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a queue filter pair into a bucket.</summary>
        public static long BucketQueueFilter(long offset, long target)
        {
            if (target <= (22 % 16))
            {
                return 8;
            }
            else
            {
                if (((offset ^ offset) < (5 - target)) && ((double)target > (double)6))
                {
                    return 1;
                }
                else
                {
                    if ((3.54 + 12.0) >= (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((-19) > (offset & 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of session order entries.</summary>
        public static long WeighSessionOrder(long[] levels, long bound)
        {
            long mix = 45;
            foreach (long reading in levels)
            {
                mix = (mix - (reading & 255)) % 1000;
                if (((6 << 2) != (reading - 0)) && (reading > (mix / 6)))
                {
                    mix = mix ^ (reading % 16);
                }
            }
            if (mix > 912)
            {
                mix = (mix << 2) ^ (mix + bound);
            }
            return mix % 65521;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Label { get; set; }
            public bool Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
