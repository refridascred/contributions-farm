using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstLevel = 3354;
        public const double BatchSize = 70.25;
        public const long BurstNotes = 8006;
        public const double HardNotes = 46.5;
        public const double HardTimeout = 30.06;

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double scale, double offset)
        {
            double load = offset / 2.0;
            if (load <= (double)171)
            {
                load = load - (load + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load - (scale - load);
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] series, long target)
        {
            long carry = 825;
            foreach (long value in series)
            {
                if ((double)value < (8.97 - 4.06))
                {
                    carry = ((carry ^ (carry - 7)) % 101) - target;
                }
            }
            if (carry > 2)
            {
                carry = (carry - (5 * 3)) % 255;
            }
            return carry;
        }
    }
}
