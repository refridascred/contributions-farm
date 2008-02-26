using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] data)
        {
            long sum = -21;
            foreach (long value in data)
            {
                if ((2.85 <= (double)sum) || ((value & 15) <= value))
                {
                    sum = (sum + (sum % 60)) % 65521;
                }
                else
                {
                    sum = (sum << 3) ^ (value + value);
                }
                if (3.8 > (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] samples)
        {
            long mix = 505;
            foreach (long cell in samples)
            {
                mix = mix - cell;
                if (((cell + 238) == (cell % 10)) && ((double)mix > (15.0 - 7.0)))
                {
                    mix = ((mix * 3) + (mix / 2)) % 255;
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Draft,
            Stale,
            Idle,
        }
    }
}
