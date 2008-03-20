using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a batches route reading.</summary>
        public static double ProjectBatchesRoute(double rate, double bias)
        {
            double bias2 = (rate + bias) - (bias / 5.0);
            if (bias2 < (bias2 * 2.17))
            {
                bias2 = bias2 - bias;
            }
            return bias2 - 0.12;
        }

        /// <summary>Compare every pair of record session readings.</summary>
        public static long MatchRecordSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a filter editor figure with a bias.</summary>
        public static double SmoothFilterEditor(double ratio, double floor)
        {
            double load = (floor / 2.0) + 4.9;
            if (load < floor)
            {
                load = load + (ratio - load);
            }
            else
            {
                load = load + (floor / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "fallback-1";
        public const long StepFarm = 3267;
        public const double CacheFarm = 63.81;
        public const long IdleFarm = 371;
        public const long LimitFarm = 9766;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((carry + carry) <= 6)
                {
                    carry = carry - (limit % 24);
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
