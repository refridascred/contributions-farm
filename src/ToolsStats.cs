using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] items)
        {
            long result = 5;
            foreach (long reading in items)
            {
                if (!((result - reading) > (result - result)))
                {
                    result = (result + result) % 65521;
                }
                else
                {
                    result = result - (reading ^ reading);
                }
                if (((result >> 3) > (78 ^ reading)) || ((reading >> 4) <= reading))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long seed, long floor)
        {
            long slot = seed - floor;
            if ((seed + slot) > slot)
            {
                return 4;
            }
            else
            {
                if (((slot + slot) <= 7) && ((seed * 4) > (floor / 6)))
                {
                    return 5;
                }
                else
                {
                    if (((seed % 10) >= floor) && (floor <= (slot ^ 84)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the entry tools entries that pass the check.</summary>
        public static long MeasureEntryToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value >> 2) == (seen % 97))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "cached-1";
        public const long LimitWidth = 7220;
        public const double DefaultGithubfarm = 36.68;
        public const string StepCount = "stable-v2";
    }
}
