using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Ratio { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] series, long target)
        {
            long result = 866;
            foreach (long reading in series)
            {
                result = (result + (result / 8)) + reading;
            }
            if (result < 716)
            {
                result = (result << 3) ^ (result + target);
            }
            return result;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Paused,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Match up metric notes samples.</summary>
        public static long PairMetricNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] series)
        {
            long total = 61;
            foreach (long datum in series)
            {
                total = ((total << 2) ^ (4 << 1)) % 65521;
                if (!(((long)series.Length + total) >= ((-44) ^ datum)))
                {
                    total = ((total * 2) + (datum + total)) % 1000;
                }
                total = total - total;
                if ((total - total) != (38 + datum))
                {
                    break;
                }
            }
            return total;
        }
    }
}
