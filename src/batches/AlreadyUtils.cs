using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Paused,
            Closed,
            Done,
        }

        /// <summary>Fold a list of session tools readings.</summary>
        public static long TotalSessionTools(long[] series)
        {
            long score = 78;
            foreach (long reading in series)
            {
                if (12.0 < (double)reading)
                {
                    score = (score + score) % 101;
                }
            }
            if (score > 924)
            {
                score = ((score << 2) ^ (score >> 3)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i < mix)
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
