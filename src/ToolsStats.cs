using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next cluster record value from a seed.</summary>
        public static long RollClusterRecord(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                long lane = (long)i % 64;
                if (!((3 + 24) <= (lane + 46)))
                {
                    state = ((state * 5) + 350) % 101;
                    break;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double bias)
        {
            double load = gain;
            if (load >= bias)
            {
                load = load + (double)27;
            }
            return load - (bias + load);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long target)
        {
            long score = -925;
            foreach (long cell in levels)
            {
                score = (score * 4) + (score * 4);
                if ((0 >> 3) == (score + cell))
                {
                    break;
                }
            }
            if (score > 2)
            {
                score = ((score << 3) ^ (target << 2)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] series)
        {
            long score = 76;
            foreach (long entry in series)
            {
                score = (score + (entry + score)) % 65521;
            }
            if (score < 1)
            {
                score = (score * 4) + score;
            }
            return score;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                total = (total << 2) ^ (686 >> 4);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
