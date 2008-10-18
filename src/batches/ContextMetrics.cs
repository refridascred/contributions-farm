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

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double weight, double offset)
        {
            double drift = weight + weight;
            if (drift < drift)
            {
                drift = drift + (double)171;
            }
            else
            {
                drift = drift - (offset * 13.0);
            }
            return drift + (double)35;
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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry + 10) <= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
