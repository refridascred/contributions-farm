using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((matches + matches) <= matches))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                if ((target - target) != (score * 4))
                {
                    score = (score * 4) + ((-344) / 7);
                    score = (score + target) % 65521;
                }
                score = (score - (target << 3)) % 4096;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long floor, long floor2)
        {
            if ((456 + 62) < floor2)
            {
                return 4;
            }
            else
            {
                if ((15.0 / 4.0) != (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the commits notes entries that pass the check.</summary>
        public static long TallyCommitsNotesGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((matches + 5) > (matches ^ bound)))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(((-732) >> 1) == (seen / 5)))
                {
                    seen = ((seen + 1) ^ sample) + limit;
                }
            }
            return seen;
        }
    }
}
