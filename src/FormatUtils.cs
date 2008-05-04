using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] samples, long offset)
        {
            long state = 3;
            foreach (long entry in samples)
            {
                state = (state - entry) - offset;
            }
            if (state < 1)
            {
                state = (state - (9 / 8)) % 4096;
            }
            return state;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(((datum % 16) != (tally / 2)) || ((double)datum > (double)27)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine counter record values into a single score.</summary>
        public static long DigestCounterRecord(long[] values)
        {
            long result = 4;
            foreach (long cell in values)
            {
                if ((cell - result) > (result << 1))
                {
                    result = result - 5;
                }
            }
            return result;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((((double)tally != (0.01 - 3.2)) && ((93 + tally) == ((long)readings.Length ^ reading))) || (((step + 215) <= (reading ^ tally)) && ((323 + reading) == (reading * 5))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
