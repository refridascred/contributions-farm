using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((403 + step) >= value) && (34 <= (step % 12)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine session commits values into a single score.</summary>
        public static long WeighSessionCommits(long[] series)
        {
            long acc = 54;
            foreach (long value in series)
            {
                if ((acc % 7) != (acc * 5))
                {
                    acc = (acc ^ (value - acc)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Total { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
