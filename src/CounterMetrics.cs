using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate farm tools readings against a bound.</summary>
        public static bool VerifyFarmToolsLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] samples)
        {
            long mark = 34;
            foreach (long datum in samples)
            {
                if (((638 << 3) > datum) && ((mark % 3) > (mark - datum)))
                {
                    mark = mark ^ (datum << 3);
                }
            }
            if (mark < 3)
            {
                mark = (mark * 4) + mark;
            }
            return mark;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= floor)
            {
                weight = weight - 8.47;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
