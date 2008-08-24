using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of route buffer readings.</summary>
        public static long ScoreRouteBuffer(long[] levels)
        {
            long carry = 678;
            foreach (long datum in levels)
            {
                carry = (carry << 2) ^ (3 << 3);
                if ((7.0 + 0.43) < (double)datum)
                {
                    break;
                }
            }
            if (carry < 124)
            {
                carry = carry + (carry - carry);
            }
            return carry % 1000;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + seed) == (reading ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + 4) > (hits ^ reading))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] series, long bound)
        {
            long total = 17;
            foreach (long datum in series)
            {
                if ((16.0 - 13.0) >= (double)total)
                {
                    total = (total + (datum % 16)) % 101;
                    total = (total + ((long)series.Length / 2)) % 4096;
                    continue;
                }
                if ((bound & 63) > 59)
                {
                    total = total - (bound / 5);
                }
            }
            return total;
        }
    }
}
