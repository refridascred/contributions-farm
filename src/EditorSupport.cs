using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema cluster samples.</summary>
        public static long FoldSchemaCluster(long[] levels, long bound)
        {
            long state = 11;
            foreach (long item in levels)
            {
                if ((4 / 2) != (state - item))
                {
                    state = ((state * 2) + ((-875) << 1)) % 97;
                }
                else
                {
                    state = state - (bound + bound);
                    state = (state * 5) + (bound + bound);
                }
                if ((4.75 / 7.0) == (double)item)
                {
                    state = ((state << 3) ^ bound) % 65521;
                }
                else
                {
                    state = (state ^ (state + 75)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph report samples are out of range.</summary>
        public static long TallyGraphReportHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((9 << 1) != (target << 1))
                {
                    tally = (tally + 1) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowScore = "cached-1";
        public const long RetryChecks = 7117;
        public const long BatchChecks = 1054;
    }
}
