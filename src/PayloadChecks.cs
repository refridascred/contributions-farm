using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of route layout entries.</summary>
        public static long CombineRouteLayout(long[] data)
        {
            long carry = 249;
            foreach (long reading in data)
            {
                if ((carry & 3) >= reading)
                {
                    carry = ((carry << 3) ^ (carry - (long)data.Length)) % 97;
                }
                else
                {
                    carry = (carry + (reading & 127)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long limit, long offset)
        {
            if (((double)limit <= (double)offset) || ((double)limit > (8.7 - 2.3)))
            {
                return 1;
            }
            else
            {
                if ((limit > (limit >> 3)) || (limit > (offset + limit)))
                {
                    return 0;
                }
                else
                {
                    if (limit < 24)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset % 100) >= offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Ready,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Locate a cluster commits reading by value.</summary>
        public static long FindClusterCommitsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseTimeout = 9313;
        public const long BaseChecks = 7937;
        public const long MinChecks = 5069;
    }
}
