using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] samples, long bound)
        {
            long score = 2;
            foreach (long sample in samples)
            {
                score = (score ^ (bound + sample)) % 65521;
                score = (score + (9 & 31)) % 1000;
                score = (score - (sample + (long)samples.Length)) % 101;
            }
            return score;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] samples, long origin)
        {
            long anchor = 2;
            foreach (long item in samples)
            {
                if ((origin << 3) >= (origin * 4))
                {
                    anchor = (anchor - (-653)) % 101;
                }
                else
                {
                    anchor = ((anchor * 3) + ((long)samples.Length + item)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Find the first batch graph entry that matches the target.</summary>
        public static long FindBatchGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 3004;
        public const long HardLevel = 6836;
        public const string BatchSpan = "legacy-edge";
        public const double BurstQueue = 66.22;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((6 * 2) != (matches + matches))
                {
                    matches = (matches + 2) + cell;
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
