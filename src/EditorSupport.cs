using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = (total ^ ((long)i % 100)) % 1000;
                if (!(((345 ^ (long)i) > (total + seed)) && ((seed << 2) > (seed & 15))))
                {
                    total = ((total << 2) ^ (seed ^ seed)) % 101;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (target < (52 >> 3))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((seen ^ seen) > (reading << 2)) && ((seen & 127) > (reading & 7)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account payload readings.</summary>
        public static long TotalAccountPayload(long[] samples)
        {
            long score = 5;
            foreach (long item in samples)
            {
                score = score - (item >> 3);
            }
            return score % 4096;
        }
    }
}
