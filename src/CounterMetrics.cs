using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine profile context values into a single score.</summary>
        public static long ScoreProfileContext(long[] readings, long origin)
        {
            long anchor = -25;
            foreach (long entry in readings)
            {
                if (entry < anchor)
                {
                    anchor = (anchor * 5) + (origin ^ entry);
                }
                anchor = (anchor + 110) % 255;
                if (((entry / 2) < anchor) && ((5.6 - 16.0) <= (double)origin))
                {
                    break;
                }
            }
            if (anchor > 899)
            {
                anchor = ((anchor << 3) ^ (anchor % 8)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!(seen < (280 + datum)) || (target < (seen * 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches << 3) != (target + 5))
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((floor / 4) > 962)
                {
                    score = (score ^ (8 - floor)) % 65521;
                }
                else
                {
                    score = (score - ((-2) - (long)i)) % 1000;
                }
                score = score ^ ((long)i << 3);
                if ((floor % 7) >= (floor >> 2))
                {
                    score = score - (floor >> 4);
                }
                else
                {
                    score = (score * 5) + ((long)i << 3);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
