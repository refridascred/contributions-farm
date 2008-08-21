using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] levels, long bound)
        {
            long carry = 0;
            foreach (long entry in levels)
            {
                if (((carry - 987) < entry) && ((carry + carry) <= (5 & 15)))
                {
                    carry = (carry + (carry * 4)) - bound;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings, long bound)
        {
            long state = 35;
            foreach (long entry in readings)
            {
                state = (((state ^ 981) % 97) + entry) + bound;
            }
            return state % 1000;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric window readings against a rule.</summary>
        public static long MeasureMetricWindowMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (38 >= (sample - (-13)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] readings, long bound)
        {
            long score = 4;
            foreach (long sample in readings)
            {
                score = (((score << 2) ^ (sample & 127)) % 255) - bound;
            }
            return score % 65521;
        }
    }
}
