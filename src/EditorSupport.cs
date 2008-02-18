using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)(-21) > (double)target))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long origin, long seed)
        {
            long step = origin ^ seed;
            if (!((4 * 2) == (origin * 2)))
            {
                return 0;
            }
            else
            {
                if ((step << 3) <= (10 + step))
                {
                    return 3;
                }
                else
                {
                    if (!(seed <= (1 ^ origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (tally > (tally * 4))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of tools profile readings.</summary>
        public static long MatchToolsProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Rank { get; set; }
            public double Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
