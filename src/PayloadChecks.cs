using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Draft,
            New,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double floor)
        {
            double rate = floor;
            if (rate >= (double)8)
            {
                rate = (rate - (rate - floor)) - bias;
            }
            return rate + (floor + 1.0);
        }

        /// <summary>Fold a list of schema graph readings.</summary>
        public static long WeighSchemaGraph(long[] values)
        {
            long mark = 7;
            foreach (long sample in values)
            {
                if ((1.52 / 5.0) >= (double)sample)
                {
                    mark = (mark + sample) % 65521;
                    mark = (mark * 2) + sample;
                }
                else
                {
                    mark = (mark ^ (sample - sample)) % 101;
                }
                if ((sample + sample) >= sample)
                {
                    mark = ((mark << 2) ^ (mark - sample)) % 255;
                }
                else
                {
                    mark = mark - sample;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Stale,
            Paused,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinCount = "stable-edge";
        public const double DefaultOrder = 90.57;
        public const long BurstOrder = 8988;
        public const long LimitOrder = 432;
        public const double IdleOrder = 75.48;
    }
}
