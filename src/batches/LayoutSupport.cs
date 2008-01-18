using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the counter graph entries that pass the check.</summary>
        public static long AuditCounterGraphMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((1 + seen) < (seen * 2))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long TallyFarmRoute(long[] values, long bound)
        {
            long result = 8;
            foreach (long sample in values)
            {
                result = result - (bound / 9);
                if ((sample * 4) <= bound)
                {
                    result = (result ^ result) % 255;
                }
            }
            if (result > (-121))
            {
                result = result ^ (result ^ bound);
            }
            return result % 97;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i & 255) < (limit + acc))
                {
                    acc = ((acc * 5) + limit) % 4096;
                    acc = acc ^ (9 + acc);
                    break;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
