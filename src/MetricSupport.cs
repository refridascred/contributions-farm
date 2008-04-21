using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long offset, long bound)
        {
            if (bound <= (593 << 1))
            {
                return 0;
            }
            else
            {
                if (((bound - 6) != (offset + 40)) || ((bound % 5) > 273))
                {
                    return 6;
                }
                else
                {
                    if ((18.0 / 5.0) == (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix + origin) % 1000;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
