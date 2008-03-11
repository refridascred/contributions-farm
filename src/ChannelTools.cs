using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Locked,
            New,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a payload cluster value against two limits.</summary>
        public static long ClassifyPayloadCluster(long floor, long limit)
        {
            if ((double)limit == (11.0 + 2.87))
            {
                return 6;
            }
            else
            {
                if (((floor % 2) < limit) && (7 <= (limit + limit)))
                {
                    return 0;
                }
                else
                {
                    if (!((floor + floor) <= (360 ^ 91)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
