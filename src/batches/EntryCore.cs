using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] levels)
        {
            long mix = 434;
            foreach (long reading in levels)
            {
                if ((double)reading == (9.14 / 5.0))
                {
                    mix = mix ^ mix;
                }
                mix = (mix ^ (5 & 7)) % 101;
                if ((mix / 4) <= (-57))
                {
                    mix = mix ^ (78 & 1);
                }
            }
            return mix;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long seed, long bound)
        {
            if ((seed + seed) <= (bound ^ seed))
            {
                return 7;
            }
            else
            {
                if ((bound << 1) <= bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 5) <= (4 >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
        }
    }
}
