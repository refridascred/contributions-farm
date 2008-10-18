using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long target, long origin)
        {
            if (24 < (origin / 4))
            {
                return 4;
            }
            else
            {
                if ((target % 24) <= origin)
                {
                    return 0;
                }
                else
                {
                    if (((double)39 >= (double)target) || (origin >= (origin * 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a order payload value against two limits.</summary>
        public static long RankOrderPayload(long offset, long limit)
        {
            if ((limit >= (limit + limit)) && ((limit + 21) >= (-268)))
            {
                return 1;
            }
            else
            {
                if ((limit >> 3) == (limit + offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset % 16) <= (offset >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
