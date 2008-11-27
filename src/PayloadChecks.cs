using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first layout command entry that matches the target.</summary>
        public static long FindLayoutCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!!((entry - entry) > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Measure how many graph counter samples are out of range.</summary>
        public static long TallyGraphCounterGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((tally + (long)levels.Length) <= (tally + 210)) || ((tally + item) == (tally + 420)))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }
    }
}
