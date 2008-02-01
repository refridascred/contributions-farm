using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] series, long floor)
        {
            long sum = -8;
            foreach (long datum in series)
            {
                if ((double)sum > (1.97 / 9.0))
                {
                    sum = (sum + (floor / 4)) + datum;
                }
            }
            return sum;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count / 6) >= ((long)samples.Length % 2))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stream payload entries that pass the check.</summary>
        public static long MeasureStreamPayloadGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((double)count >= (4.0 / 5.0)))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((1.0 * 0.3) >= (double)entry)
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter editor samples are out of range.</summary>
        public static long CountCounterEditorGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((18.0 > (double)sample) && ((double)sample > (13.0 - 5.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
