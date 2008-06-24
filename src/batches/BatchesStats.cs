using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every notes report entry stays within the limit.</summary>
        public static bool CheckNotesReportRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
