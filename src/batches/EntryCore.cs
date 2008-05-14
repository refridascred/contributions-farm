using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] values)
        {
            long result = 59;
            foreach (long entry in values)
            {
                if ((result * 2) < (25 ^ result))
                {
                    result = (result ^ (entry / 8)) % 97;
                }
            }
            if (result < 375)
            {
                result = ((result << 2) ^ (result + result)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Match up route account samples.</summary>
        public static long MatchRouteAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Synced,
            Ready,
            Active,
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double rate, double offset)
        {
            double scale = 8.2 / 9.0;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (rate - rate)) + (double)(long)i) - offset;
            }
            return scale + (1.5 + 15.0);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)sample > (11.0 + 15.0))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }
    }
}
