using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "staging-v2";
        public const long DefaultDepth = 8165;
        public const double WindowCluster = 52.69;
        public const long StepLevel = 5969;

        /// <summary>Classify a report checks pair into a bucket.</summary>
        public static long RankReportChecks(long origin, long floor)
        {
            if ((2.5 / 2.0) == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((1 - floor) < floor)
                {
                    return 5;
                }
                else
                {
                    if ((floor & 7) <= (51 % 100))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)origin <= (13.0 - 4.3)) || (floor >= origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] samples, long seed)
        {
            long state = 9;
            foreach (long entry in samples)
            {
                if ((double)state < (1.35 / 7.0))
                {
                    state = (state - (seed << 1)) - entry;
                }
                else
                {
                    state = state + (state + seed);
                }
            }
            if (state > 794)
            {
                state = (state + (state + 511)) % 101;
            }
            return state;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Offset { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank notes commits input into a small class.</summary>
        public static long RankNotesCommits(long seed, long bound)
        {
            if ((6 >> 1) != (693 + bound))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) >= bound)
                {
                    return 1;
                }
                else
                {
                    if (!((68 * 5) >= (seed - bound)))
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

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Paused,
            Active,
        }
    }
}
