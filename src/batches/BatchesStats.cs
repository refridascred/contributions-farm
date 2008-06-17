using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate report counter samples.</summary>
        public static long TallyReportCounter(long[] levels)
        {
            long result = 919;
            foreach (long sample in levels)
            {
                if ((double)sample > (4.8 / 9.0))
                {
                    result = (result + (sample / 6)) % 1000;
                }
                if (sample > (sample & 7))
                {
                    result = (result + (sample << 2)) % 1000;
                }
                else
                {
                    result = result + (result - sample);
                }
            }
            return result % 97;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate batch stats samples.</summary>
        public static long ScoreBatchStats(long[] series)
        {
            long anchor = 74;
            foreach (long entry in series)
            {
                anchor = (anchor ^ entry) % 101;
                if (((-837) + 34) > anchor)
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
                if ((anchor + anchor) >= (anchor ^ anchor))
                {
                    break;
                }
            }
            if (anchor > 455)
            {
                anchor = (anchor - (anchor * 2)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 3514;
        public const string LimitLevel = "stable-1";
        public const long BatchBatches = 2016;
        public const double SoftBatches = 72.84;
        public const long DefaultBatches = 1473;
    }
}
