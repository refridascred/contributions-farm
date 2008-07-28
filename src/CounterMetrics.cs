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

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 9297;
        public const long SoftScore = 7375;
        public const long BaseLevel = 741;
        public const long MaxTimeout = 87;
        public const string MaxToken = "strict-edge";

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
