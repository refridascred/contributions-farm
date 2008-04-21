using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits < (13.0 + 1.79))
                {
                    hits = ((hits + 3) + sample) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Count { get; set; } = "";
            public bool Level { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate profile command readings against a bound.</summary>
        public static bool ValidateProfileCommandRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate profile farm samples.</summary>
        public static long WeighProfileFarm(long[] items)
        {
            long acc = 8;
            foreach (long value in items)
            {
                if (((acc + value) <= (acc ^ acc)) || (value < (value & 3)))
                {
                    acc = (acc ^ ((-44) + (long)items.Length)) % 101;
                }
                else
                {
                    acc = acc ^ (value + acc);
                }
                if (acc >= (acc ^ value))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
