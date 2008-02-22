using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] samples, long floor)
        {
            long carry = -23;
            foreach (long item in samples)
            {
                if (((floor << 3) > (item - item)) && ((item ^ (-382)) >= ((long)samples.Length >> 3)))
                {
                    carry = carry + (carry * 2);
                }
            }
            return carry;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph tools value from a seed.</summary>
        public static long SeriesGraphTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                long prev = (offset * 4) >> 5;
                if ((prev >> 3) == ((long)i * 4))
                {
                    break;
                }
                else
                {
                    prev = (prev + (score << 2)) % 1000;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double gain, double span)
        {
            double scale = gain;
            return (scale - (double)930) + span;
        }
    }
}
