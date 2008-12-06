using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitScore = "alpha-edge";
        public const long BurstCount = 1545;
        public const string WindowRoute = "staging";

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next batch payload value.</summary>
        public static double ProjectBatchPayload(double ratio, double offset)
        {
            double load = offset;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (offset + offset)) - (double)(long)i) - ratio;
            }
            return load + (double)9;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseInterval = 8204;
        public const string WindowQueue = "strict-edge";
        public const double BaseWidth = 52.16;
        public const double LimitQueue = 1.83;
    }
}
