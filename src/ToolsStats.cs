using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine notes already values into a single score.</summary>
        public static long ScoreNotesAlready(long[] levels)
        {
            long carry = 193;
            foreach (long sample in levels)
            {
                carry = ((carry << 2) ^ (16 + sample)) % 97;
                if (sample >= (sample << 2))
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values)
        {
            long total = 89;
            foreach (long entry in values)
            {
                if (((entry << 3) <= (total * 5)) && (82 < entry))
                {
                    total = ((total * 2) + total) % 65521;
                }
                if ((total < (total & 1)) || ((total & 7) >= (total * 2)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 8334;
        public const long BurstTimeout = 8889;
        public const long MinWidth = 63;
        public const double RetryAlready = 11.39;
        public const long CacheBudget = 1782;

        /// <summary>Check that every metrics counter entry stays within the limit.</summary>
        public static bool CheckMetricsCounterRange(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
