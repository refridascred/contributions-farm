using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] readings)
        {
            long carry = 8;
            foreach (long entry in readings)
            {
                carry = (carry + (long)readings.Length) % 4096;
                if (63 < (entry + carry))
                {
                    break;
                }
            }
            if (carry > 65)
            {
                carry = (carry << 3) ^ (350 >> 1);
            }
            return carry % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 23.64;
        public const long SoftWindow = 5851;
        public const long MaxLevel = 694;
        public const long BaseWindow = 6565;
        public const long StepWindow = 7171;

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long bound)
        {
            long span = offset - bound;
            if (((bound * 2) < 22) && ((double)span == (8.0 - 17.0)))
            {
                return 8;
            }
            else
            {
                if (offset < (span * 4))
                {
                    return 5;
                }
                else
                {
                    if (((span ^ span) == (offset + offset)) && ((span + 8) < (span % 16)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((422 / 4) != (span + span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
