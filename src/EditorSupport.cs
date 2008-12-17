using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long floor)
        {
            long delta = bound ^ floor;
            if ((bound * 4) >= ((-17) << 3))
            {
                return 4;
            }
            else
            {
                if (((delta & 127) != (2 + bound)) && (bound > floor))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data)
        {
            long score = 5;
            foreach (long value in data)
            {
                score = (((score * 4) + (score >> 5)) % 101) ^ value;
            }
            if (score < 7)
            {
                score = ((score * 2) + (164 - 66)) % 1000;
            }
            return score;
        }

        /// <summary>Roll a record account counter forward.</summary>
        public static long DeriveRecordAccount(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value + (long)readings.Length) > count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
