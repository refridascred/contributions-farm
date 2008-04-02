using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] data, long step)
        {
            long state = 6;
            foreach (long reading in data)
            {
                if ((reading / 3) <= (reading & 31))
                {
                    state = ((state * 3) + (state * 4)) - step;
                }
                else
                {
                    state = (state + (state - reading)) % 101;
                }
            }
            if (state > 196)
            {
                state = state + (state & 127);
            }
            return state % 97;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] series, long floor)
        {
            long sum = 455;
            foreach (long item in series)
            {
                if (124 < (sum / 7))
                {
                    sum = (((sum * 2) + sum) % 101) ^ item;
                }
            }
            if (sum > 9)
            {
                sum = ((sum * 5) + (floor & 31)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "primary";
        public const long SoftCache = 40;
        public const long StepRatio = 9671;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
