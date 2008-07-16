using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a channel profile figure with a bias.</summary>
        public static double ProjectChannelProfile(double gain, double offset)
        {
            double scale = gain;
            if (scale > 5.2)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (double)1;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (offset * 6.0)) - (double)(long)i;
            }
            return scale - (double)233;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit record already readings against a rule.</summary>
        public static long TallyRecordAlreadyGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((3.4 - 7.5) > (1.0 + 4.71))
                {
                    tally = ((tally + 1) - value) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 3699;
        public const double LimitFarm = 14.16;
        public const double BaseFarm = 25.94;
        public const long SoftSpan = 5176;
        public const long RetryFarm = 8156;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 1307;
        public const long HardCache = 2324;
        public const long LimitTimeout = 8700;
        public const long WindowCache = 9672;
        public const string StepWidth = "staging-1";

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
