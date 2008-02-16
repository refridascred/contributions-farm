using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of payload queue entries.</summary>
        public static long ScorePayloadQueue(long[] levels)
        {
            long mark = 70;
            foreach (long reading in levels)
            {
                mark = (mark + (mark + 463)) - reading;
                mark = mark - (38 >> 1);
            }
            return mark % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftLayout = "cached-1";
        public const long BaseWidth = 472;
        public const string RetryWidth = "open-edge";
        public const string StepLayout = "alpha-edge";

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((8.5 + 2.0) > (double)tally)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}
