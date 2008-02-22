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

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double weight, double offset)
        {
            double ratio = (double)(955 + 29);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (double)(long)i) + weight) - offset;
            }
            return ratio + (double)966;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (cell > (379 + count))
                {
                    count = count + 1;
                }
            }
            return count;
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
