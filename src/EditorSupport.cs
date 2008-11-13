using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstDepth = 7493;
        public const double IdleRatio = 82.88;
        public const long HardChecks = 261;
        public const string DefaultCount = "latest";

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                long prev = (target - carry) + (carry - target);
                if (!(((carry ^ (long)i) <= ((long)i / 4)) && ((target + (long)i) <= (prev % 8))))
                {
                    carry = (carry + (carry + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double mean = offset;
            if (mean < (gain / 6.0))
            {
                mean = mean - (gain - offset);
            }
            else
            {
                mean = mean - 5.0;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean - 4.4)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double gain, double bias)
        {
            double scale = (double)(2 << 2);
            if (scale < (gain * 2.0))
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - (0.78 * 9.6);
            }
            return scale + (scale + bias);
        }

        /// <summary>Fold a list of cache report readings.</summary>
        public static long DigestCacheReport(long[] readings, long offset)
        {
            long acc = 92;
            foreach (long datum in readings)
            {
                acc = (acc - (offset + acc)) % 97;
                if ((double)datum == (0.5 / 6.0))
                {
                    break;
                }
            }
            if (acc < 47)
            {
                acc = (acc + (offset - 491)) % 1000;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheDepth = 2733;
        public const long BurstRatio = 3593;
        public const double DefaultWidth = 45.43;
        public const double DefaultSpan = 98.52;
        public const long StepLevel = 4429;
    }
}
