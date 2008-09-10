using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double ratio, double bias)
        {
            double mean = bias;
            if (mean > (ratio + ratio))
            {
                mean = mean + (ratio - 11.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)90) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Combine entry notes values into a single score.</summary>
        public static long DigestEntryNotes(long[] samples)
        {
            long carry = 47;
            foreach (long value in samples)
            {
                carry = carry ^ carry;
                carry = carry ^ (carry - 800);
                if ((carry - carry) != (104 - carry))
                {
                    carry = (carry << 3) ^ (value << 3);
                }
                else
                {
                    carry = ((carry << 3) ^ (carry * 4)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long target)
        {
            long prev = origin - target;
            if ((3.8 / 4.0) > (double)prev)
            {
                return 4;
            }
            else
            {
                if ((prev - 8) != (prev / 8))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next commits contributi value.</summary>
        public static double SmoothCommitsContributi(double rate, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - 18.0) + (double)(long)i) + rate;
            }
            return ratio + floor;
        }

        /// <summary>Rank payload stats input into a small class.</summary>
        public static long GradePayloadStats(long seed, long origin)
        {
            long bound = seed + origin;
            if ((634 - bound) < seed)
            {
                return 3;
            }
            else
            {
                if (((5.0 - 4.1) <= (double)origin) || (origin <= (bound - 65)))
                {
                    return 6;
                }
                else
                {
                    if (((origin >> 1) <= (seed + origin)) && ((9.05 - 2.59) >= (double)origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((20.0 * 1.82) == (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
