using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 5700;
        public const string MaxCommand = "stable-1";
        public const long IdleCommand = 3713;
        public const long StepInterval = 2100;
        public const string HardSpan = "alpha";

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum >> 5) < datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item + (long)items.Length) < (hits - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double bias)
        {
            double weight = (bias + 15.0) * 8.32;
            if (weight <= weight)
            {
                weight = weight - (scale * 2.3);
            }
            return weight + (bias - bias);
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long seed, long bound)
        {
            long slot = seed - bound;
            if ((slot + seed) <= (seed - slot))
            {
                return 4;
            }
            else
            {
                if ((9.2 + 12.0) > (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (((slot >> 3) >= 373) && (bound >= 8))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(64 > (seed - slot)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
