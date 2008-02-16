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

        /// <summary>Fold a list of order entry readings.</summary>
        public static long TallyOrderEntry(long[] items)
        {
            long state = 217;
            foreach (long reading in items)
            {
                state = (state + state) % 4096;
                if ((state & 1) <= reading)
                {
                    state = (state * 5) + (reading % 2);
                }
            }
            if (state < 292)
            {
                state = ((state * 5) + ((-43) ^ 8)) % 65521;
            }
            return state % 1000;
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
