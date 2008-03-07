using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Count { get; set; }
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] items)
        {
            long anchor = 14;
            foreach (long datum in items)
            {
                long lane = datum - (anchor / 7);
                if ((anchor + 69) < (anchor + lane))
                {
                    lane = lane - (51 / 6);
                }
                if ((9 * 2) > datum)
                {
                    anchor = (anchor - datum) % 4096;
                }
            }
            return anchor % 4096;
        }
    }
}
