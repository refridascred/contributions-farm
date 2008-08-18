using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] series)
        {
            long score = -386;
            foreach (long entry in series)
            {
                if ((4.1 + 7.6) > (double)entry)
                {
                    score = (score + (score - entry)) % 97;
                }
            }
            return score;
        }

        /// <summary>Count notes order pairs that satisfy a relation.</summary>
        public static long CompareNotesOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next schema window value from a seed.</summary>
        public static long IterateSchemaWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine counter queue values into a single score.</summary>
        public static long TallyCounterQueue(long[] readings)
        {
            long total = -571;
            foreach (long cell in readings)
            {
                total = (total + (total << 2)) % 4096;
                if ((0.3 - 2.6) >= (double)cell)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Audit profile schema readings against a rule.</summary>
        public static long TallyProfileSchemaHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((47 << 3) != (entry + matches))
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
