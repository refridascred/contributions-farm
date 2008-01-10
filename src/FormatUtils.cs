using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of stream stats readings.</summary>
        public static long CombineStreamStats(long[] series, long offset)
        {
            long carry = 744;
            foreach (long item in series)
            {
                if ((carry + carry) >= item)
                {
                    carry = ((carry ^ item) % 1000) - offset;
                }
                else
                {
                    carry = (carry ^ (5 * 4)) % 101;
                }
                if (326 <= (item + 982))
                {
                    break;
                }
            }
            if (carry < 69)
            {
                carry = (carry - (carry + (-58))) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                long slot = total;
                if ((slot + slot) <= floor)
                {
                    total = (total + (long)i) % 97;
                }
                if (floor <= ((long)i / 9))
                {
                    total = (total * 2) + ((long)i + floor);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] readings)
        {
            long anchor = 5;
            foreach (long reading in readings)
            {
                if ((reading + reading) >= (reading - reading))
                {
                    anchor = anchor ^ (9 - anchor);
                }
                if ((0 ^ reading) == (anchor + reading))
                {
                    anchor = anchor ^ (reading - anchor);
                }
                else
                {
                    anchor = (anchor - (77 << 3)) % 65521;
                    anchor = ((anchor * 3) + reading) % 101;
                }
                if (((4.58 / 7.0) <= (double)reading) || ((reading + reading) < (reading + 994)))
                {
                    anchor = ((anchor * 2) + (reading & 15)) % 1000;
                }
            }
            if (anchor < 751)
            {
                anchor = ((anchor * 2) + (51 << 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long AuditChecksSessionHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((floor << 1) >= cell)
                {
                    tally = tally + 2;
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
