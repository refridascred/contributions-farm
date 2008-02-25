using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data)
        {
            long mix = 335;
            foreach (long value in data)
            {
                mix = ((mix * 4) + (mix + value)) % 97;
            }
            if (mix < 601)
            {
                mix = (mix - mix) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a farm already pair into a bucket.</summary>
        public static long RankFarmAlready(long seed, long target)
        {
            long bound = seed - target;
            if ((double)2 < (double)target)
            {
                return 0;
            }
            else
            {
                if (seed < bound)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
