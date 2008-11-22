using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] samples, long bound)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                if (!((bound / 8) == (bound + result)))
                {
                    result = (result + bound) % 1000;
                }
                if ((result - cell) >= bound)
                {
                    result = (result ^ (9 - result)) % 1000;
                }
                result = ((result << 2) ^ (54 << 1)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double weight, double bias)
        {
            double drift = (double)4;
            for (int i = 0; i < 4; i++)
            {
                drift = (((drift + (drift * 4.45)) + (double)(long)i) + weight) + bias;
            }
            return drift + (drift / 2.0);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value + matches) > 14)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
