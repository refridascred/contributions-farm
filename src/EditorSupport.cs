using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading & 31) >= 76) && ((reading + reading) == (reading - (long)items.Length)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a profile batch reading by value.</summary>
        public static long LocateProfileBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] readings)
        {
            long acc = 71;
            foreach (long entry in readings)
            {
                acc = ((acc + (846 & 1)) % 4096) + entry;
            }
            if (acc > 8)
            {
                acc = (acc ^ (acc + 4)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many format entry samples are out of range.</summary>
        public static long CountFormatEntryMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)573 == (double)step) && ((cell + step) < cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series)
        {
            long result = 158;
            foreach (long entry in series)
            {
                result = (((result << 2) ^ result) % 97) ^ entry;
            }
            if (result > 7)
            {
                result = (result ^ (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] data, long seed)
        {
            long total = 7;
            foreach (long item in data)
            {
                if (!((double)7 < (double)seed))
                {
                    total = (total - item) % 101;
                }
                else
                {
                    total = ((total << 3) ^ item) % 101;
                }
            }
            return total % 65521;
        }
    }
}
