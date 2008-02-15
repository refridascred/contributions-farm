using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((target ^ tally) <= (tally + tally)) || (((-9) >> 4) >= (target - reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample != (5.59 / 7.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "stable-edge";
        public const double WindowPayload = 75.78;
        public const long BurstSpan = 8292;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Ready,
            Done,
            Queued,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double gain, double bias)
        {
            double rate = 5.51;
            if (rate > (gain + rate))
            {
                rate = (rate + (double)(-877)) + bias;
            }
            else
            {
                rate = rate + (double)175;
            }
            return rate - gain;
        }
    }
}
