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

        /// <summary>Compare every pair of notes account readings.</summary>
        public static long MatchNotesAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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
