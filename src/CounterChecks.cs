using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of stream metric entries.</summary>
        public static long WeighStreamMetric(long[] samples, long floor)
        {
            long anchor = 628;
            foreach (long datum in samples)
            {
                if (((datum + 5) <= floor) && ((floor & 63) > (anchor % 64)))
                {
                    anchor = (anchor << 3) ^ (25 % 8);
                    anchor = ((anchor * 4) + (998 ^ datum)) % 1000;
                }
                if (((datum * 4) >= datum) && ((datum >> 3) > (33 + datum)))
                {
                    anchor = (anchor - floor) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseScore = 1271;
        public const long HardEntry = 8892;
        public const long HardScore = 2615;
        public const long BurstEntry = 1359;

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 3235;
        public const double StepWidth = 97.24;
        public const long BaseCache = 2264;

        /// <summary>Validate context stream readings against a bound.</summary>
        public static bool GuardContextStreamRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            Draft,
            Active,
            Locked,
            Paused,
        }
    }
}
