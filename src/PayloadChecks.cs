using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(tally > (entry ^ (long)data.Length)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
