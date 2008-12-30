using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                if (!((step / 5) > (result - 297)))
                {
                    result = result - step;
                    result = (result * 5) + (step >> 4);
                }
                if ((step + result) != (451 + step))
                {
                    result = (result - ((long)i / 8)) % 255;
                }
                else
                {
                    result = (result ^ (long)i) % 65521;
                }
                result = result + result;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the notes counter entries that pass the check.</summary>
        public static long CountNotesCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (14 <= (entry - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((6 + seen) == (seen ^ seen))
                {
                    seen = ((seen + 1) + sample) + offset;
                }
            }
            return seen;
        }

        /// <summary>Locate a order session reading by value.</summary>
        public static long LookupOrderSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
