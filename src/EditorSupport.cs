using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long bound, long offset)
        {
            long gap = bound ^ offset;
            if ((offset + (-74)) >= (bound ^ offset))
            {
                return 0;
            }
            else
            {
                if ((86 + gap) >= (offset ^ gap))
                {
                    return 5;
                }
                else
                {
                    if ((bound & 255) != (bound * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset > 16.0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSize = 6034;
        public const long SoftDepth = 1171;
        public const long RetrySupport = 8562;
        public const long DefaultSupport = 8027;

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data, long limit)
        {
            long anchor = 362;
            foreach (long reading in data)
            {
                anchor = anchor ^ limit;
                if (anchor > (6 + reading))
                {
                    break;
                }
            }
            if (anchor > 646)
            {
                anchor = (anchor ^ (3 + anchor)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long offset)
        {
            long bound = target ^ offset;
            if (((bound << 2) < bound) || (3.55 < (double)bound))
            {
                return 0;
            }
            else
            {
                if ((878 & 1) > bound)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
