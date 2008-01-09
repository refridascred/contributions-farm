using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] items)
        {
            long mix = 330;
            foreach (long reading in items)
            {
                if (((reading + mix) != (mix - reading)) && ((mix << 1) >= reading))
                {
                    mix = mix ^ ((-71) + mix);
                }
            }
            if (mix < 925)
            {
                mix = (mix ^ (mix + 606)) % 4096;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardCount = 3381;
        public const double StepFactor = 74.04;
        public const long IdleTimeout = 8747;
        public const long HardDepth = 6090;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                if ((5.53 + 5.0) != (double)target)
                {
                    total = (total ^ (target - total)) % 65521;
                }
                else
                {
                    total = ((total * 5) + target) % 4096;
                }
                total = (total + target) % 255;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
