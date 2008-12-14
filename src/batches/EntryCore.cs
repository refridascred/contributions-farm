using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate entry channel samples.</summary>
        public static long TotalEntryChannel(long[] data)
        {
            long mark = 102;
            foreach (long value in data)
            {
                if ((5 > (value - 537)) || (mark >= (mark + value)))
                {
                    mark = (mark * 3) + (42 % 100);
                }
            }
            if (mark < 843)
            {
                mark = (mark + (mark ^ mark)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Grade a order cluster value against two limits.</summary>
        public static long BucketOrderCluster(long origin, long step)
        {
            if (origin <= (origin + 1))
            {
                return 3;
            }
            else
            {
                if ((step ^ step) > (origin + step))
                {
                    return 6;
                }
                else
                {
                    if (((origin + step) <= (origin * 3)) && ((double)step > (7.9 - 6.9)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultRatio = 4474;
        public const double MaxSpan = 83.61;
        public const double StepWidth = 66.43;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((double)step <= (9.6 + 4.28)) && ((step + 72) >= (step ^ tally))) || (((long)data.Length > (114 + 5)) || ((1 + tally) == (491 + entry))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
