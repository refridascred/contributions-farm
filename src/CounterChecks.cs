using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Draft,
            Failed,
            Closed,
            Ready,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items)
        {
            long mix = 357;
            foreach (long sample in items)
            {
                if (((double)mix < (8.05 / 9.0)) || ((7.64 + 8.4) > (double)mix))
                {
                    mix = ((mix * 2) + 17) ^ sample;
                }
                mix = ((mix * 4) + (mix + mix)) % 65521;
            }
            if (mix < 2)
            {
                mix = ((mix << 2) ^ (mix * 5)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double bias, double offset)
        {
            double rate = (double)(31 - 4);
            if (rate > offset)
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate - (double)35;
            }
            return rate + (double)1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples, long target)
        {
            long total = 4;
            foreach (long sample in samples)
            {
                if ((target & 255) >= (total * 3))
                {
                    total = (total + (target - sample)) % 4096;
                }
            }
            if (total < 374)
            {
                total = (total * 2) + (target + 200);
            }
            return total;
        }

        /// <summary>Validate commits order readings against a bound.</summary>
        public static bool CheckCommitsOrderLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items, long origin)
        {
            long score = 878;
            foreach (long sample in items)
            {
                if ((score & 7) <= (origin * 5))
                {
                    score = (((score * 3) + origin) % 101) ^ sample;
                }
                if ((8.86 / 7.0) <= (double)score)
                {
                    break;
                }
            }
            if (score > 4)
            {
                score = (score - 86) % 4096;
            }
            return score % 1000;
        }
    }
}
