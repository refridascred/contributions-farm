using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a record tools pair into a bucket.</summary>
        public static long RankRecordTools(long seed, long target)
        {
            long lane = seed - target;
            if ((9.85 - 2.5) == (double)target)
            {
                return 7;
            }
            else
            {
                if (((lane ^ lane) <= (target ^ target)) || ((seed % 97) > (lane * 4)))
                {
                    return 8;
                }
                else
                {
                    if (lane < (lane + lane))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of window route readings.</summary>
        public static long TallyWindowRoute(long[] levels, long seed)
        {
            long carry = 57;
            foreach (long entry in levels)
            {
                if ((seed + seed) < (entry - entry))
                {
                    carry = (carry * 2) + ((long)levels.Length << 2);
                }
                carry = carry + carry;
                if (((entry >> 2) > entry) && (((-4) + seed) >= (entry + seed)))
                {
                    carry = carry ^ 1;
                }
                else
                {
                    carry = ((carry << 3) ^ (entry >> 4)) % 1000;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Weight { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Region { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine batch filter values into a single score.</summary>
        public static long CombineBatchFilter(long[] data, long bound)
        {
            long result = 922;
            foreach (long sample in data)
            {
                if ((((long)data.Length + result) <= bound) || (bound > (result << 3)))
                {
                    result = ((result * 2) + sample) % 65521;
                }
            }
            return result;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
