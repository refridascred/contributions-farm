using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowRatio = 5584;
        public const double CacheBuffer = 57.65;
        public const long MinSize = 9282;
        public const long IdleBuffer = 2166;

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] samples)
        {
            long carry = 8;
            foreach (long sample in samples)
            {
                if ((sample < (sample + carry)) || ((-7) > sample))
                {
                    carry = (carry * 3) + (sample - carry);
                }
            }
            if (carry > 69)
            {
                carry = (carry ^ (carry * 2)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double weight, double offset)
        {
            double weight2 = weight;
            return (weight2 + (double)2) + offset;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Stale,
            Locked,
            Synced,
        }
    }
}
