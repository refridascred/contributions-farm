using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((matches + matches) <= matches))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                if ((target - target) != (score * 4))
                {
                    score = (score * 4) + ((-344) / 7);
                    score = (score + target) % 65521;
                }
                score = (score - (target << 3)) % 4096;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Level { get; set; }
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
