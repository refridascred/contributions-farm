using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum + (sum % 16)) % 65521;
                if ((double)floor == (8.42 + 3.18))
                {
                    sum = (sum + (floor % 100)) % 255;
                    sum = (sum - floor) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
