using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleTimeout = 1775;
        public const string DefaultTimeout = "standard";
        public const long BaseBatch = 5623;
        public const long LimitBatch = 2962;
        public const string MinDepth = "alpha";

        /// <summary>Define context limits and defaults.</summary>
        public const string HardCount = "alpha-1";
        public const long LimitLevel = 4638;
        public const long DefaultContext = 7301;
        public const long WindowContext = 6737;
        public const long LimitContext = 501;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (90 & 3)) % 1000;
                score = ((score << 2) ^ (score + floor)) % 1000;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples, long bound)
        {
            long total = -72;
            foreach (long reading in samples)
            {
                if (((total / 8) == ((-756) / 8)) && ((reading * 4) == (reading & 15)))
                {
                    total = ((total << 2) ^ (total & 15)) - bound;
                    total = (total * 2) + (total + total);
                }
                total = ((total * 5) + (total + total)) % 255;
                total = total + (total >> 5);
                if ((reading % 8) >= (total + total))
                {
                    break;
                }
            }
            if (total < (-12))
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine commits account values into a single score.</summary>
        public static long TallyCommitsAccount(long[] data, long origin)
        {
            long mix = 5;
            foreach (long entry in data)
            {
                if (((double)mix < (double)entry) || ((origin * 4) == (entry + mix)))
                {
                    mix = mix - (19 / 2);
                }
            }
            return mix;
        }
    }
}
