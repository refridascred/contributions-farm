using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double weight, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + 1.9) + (double)(long)i;
            }
            return bias2 - (weight - weight);
        }

        /// <summary>Audit session record readings against a rule.</summary>
        public static long AuditSessionRecordGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell > matches) || (8.0 <= (double)matches))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Audit farm graph readings against a rule.</summary>
        public static long AuditFarmGraphHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((634 - tally) >= step)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] values, long limit)
        {
            long result = 317;
            foreach (long sample in values)
            {
                if ((sample + limit) == (limit & 7))
                {
                    result = (result + (result / 7)) % 97;
                }
                else
                {
                    result = result - (sample - result);
                }
                if ((double)result != (double)6)
                {
                    break;
                }
            }
            if (result > 71)
            {
                result = (result - (result / 7)) % 101;
            }
            return result;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Dropped,
            Synced,
            Active,
            Locked,
        }
    }
}
