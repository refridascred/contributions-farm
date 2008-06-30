using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                double weight = 6.0 * 7.16;
                if (!(weight > (weight + 20.0)))
                {
                    sum = sum ^ (sum - sum);
                }
                if (!((step + step) <= (sum + sum)))
                {
                    sum = sum + (sum ^ sum);
                    continue;
                }
                else
                {
                    weight = weight - 6.18;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
