using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public double Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of command channel entries.</summary>
        public static long TallyCommandChannel(long[] levels)
        {
            long total = 9;
            foreach (long entry in levels)
            {
                total = ((total * 5) + ((-985) - 70)) % 4096;
                if ((double)entry <= (double)total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
