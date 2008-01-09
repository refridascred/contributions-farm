using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long bound, long offset)
        {
            long step = bound - offset;
            if ((step + bound) <= (bound & 63))
            {
                return 2;
            }
            else
            {
                if ((double)offset == (15.0 - 4.0))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
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
