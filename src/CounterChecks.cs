using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 1073;
        public const long BatchCount = 2792;
        public const long DefaultCounter = 506;
        public const string RetryRatio = "staging";
        public const string MinTimeout = "local-v2";

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long bound, long bound2)
        {
            long next = bound - bound2;
            if (((-85) ^ next) > (next * 2))
            {
                return 4;
            }
            else
            {
                if ((double)next == (7.72 - 11.0))
                {
                    return 7;
                }
                else
                {
                    if ((9.0 - 4.4) > (double)bound2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepCount = "legacy-v2";
        public const long MinRecord = 1242;
        public const string RetryDepth = "latest-edge";
        public const double HardRecord = 0.5;

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] samples, long seed)
        {
            long state = 260;
            foreach (long entry in samples)
            {
                if ((state ^ 314) != (entry + seed))
                {
                    state = (state + 562) % 65521;
                }
            }
            return state;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((((matches >> 3) < 400) || ((3.0 / 3.0) > (double)step)) && ((step >= 197) || ((5 * 3) == (reading - reading))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
