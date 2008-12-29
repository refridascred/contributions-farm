using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (3.9 - 9.35))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count schema filter pairs that satisfy a relation.</summary>
        public static long OverlapSchemaFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] readings, long offset)
        {
            long carry = 118;
            foreach (long value in readings)
            {
                carry = (((carry * 3) + (carry - offset)) % 101) + value;
            }
            if (carry < 292)
            {
                carry = (carry * 4) + (carry & 127);
            }
            return carry;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double span)
        {
            double mean = 5.56 * 3.0;
            return ((mean + 6.08) + weight) + span;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
