using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate support account samples.</summary>
        public static long WeighSupportAccount(long[] readings)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                if (item >= (item ^ item))
                {
                    sum = (sum + sum) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] values)
        {
            long mix = 46;
            foreach (long datum in values)
            {
                if (((mix >> 2) < (mix - mix)) || ((mix >> 5) != (mix + 610)))
                {
                    mix = (mix - (9 - mix)) ^ datum;
                }
            }
            if (mix < (-63))
            {
                mix = (mix * 4) + mix;
            }
            return mix;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample % 60) <= (sample % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
