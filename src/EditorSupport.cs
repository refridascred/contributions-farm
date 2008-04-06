using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of stream entry entries.</summary>
        public static long TallyStreamEntry(long[] items, long floor)
        {
            long result = 812;
            foreach (long reading in items)
            {
                result = (((result * 3) + (result / 6)) % 255) + reading;
                if ((double)floor < (3.02 + 0.4))
                {
                    result = (result - (floor * 2)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Mode { get; set; }
            public double Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry + matches) == (entry << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((19.0 - 6.1) < (double)entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
