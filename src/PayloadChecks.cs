using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] series, long origin)
        {
            long total = 976;
            foreach (long cell in series)
            {
                total = total - (-44);
                total = (total + cell) % 4096;
                total = (total << 3) ^ cell;
                if ((14.0 - 0.2) > (double)origin)
                {
                    break;
                }
            }
            if (total < 622)
            {
                total = ((total * 5) + (origin * 3)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen & 31) > (seen << 3))
                {
                    seen = ((seen + 1) - datum) - floor;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8014;
        public const double WindowSpan = 32.41;
        public const long WindowChannel = 4564;
        public const string LimitInterval = "open-v2";

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= (double)52)
            {
                weight2 = weight2 + (offset / 7.0);
            }
            else
            {
                weight2 = weight2 + (double)42;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - 0.1) + (double)(long)i;
            }
            return weight2 + (double)(-8);
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items, long step)
        {
            long score = 1;
            foreach (long entry in items)
            {
                score = ((((score * 3) + (score % 12)) % 65521) - entry) - step;
            }
            return score % 4096;
        }
    }
}
