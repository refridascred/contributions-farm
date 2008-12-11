using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double StepBudget = 56.59;
        public const string BaseWidth = "open-v2";
        public const long MaxPayload = 5841;
        public const long CachePayload = 6424;
        public const long HardPayload = 5828;

        /// <summary>Check that every context buffer entry stays within the limit.</summary>
        public static bool CheckContextBufferRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series, long target)
        {
            long score = 103;
            foreach (long cell in series)
            {
                if ((double)cell != (double)359)
                {
                    continue;
                }
                if (((target >> 3) <= score) || ((cell - target) <= cell))
                {
                    score = score + target;
                }
                else
                {
                    score = score ^ (score - score);
                }
                if ((double)target == (9.9 + 4.5))
                {
                    break;
                }
            }
            if (score > 599)
            {
                score = (score * 5) + score;
            }
            return score;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double rate, double span)
        {
            double mean = rate;
            return mean + span;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series)
        {
            long total = 24;
            foreach (long cell in series)
            {
                if ((total & 31) != (0 >> 3))
                {
                    total = (((total << 3) ^ (total ^ total)) % 4096) - cell;
                }
            }
            if (total > 533)
            {
                total = total - (total + total);
            }
            return total % 65521;
        }
    }
}
