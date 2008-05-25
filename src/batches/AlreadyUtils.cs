using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSpan = 9380;
        public const long HardFactor = 582;
        public const long StepGraph = 1921;

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the notes entry entries that pass the check.</summary>
        public static long TallyNotesEntryOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample > matches)
                {
                    matches = (matches + 2) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell - cell) == (cell + 56))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of route batch entries.</summary>
        public static long WeighRouteBatch(long[] data)
        {
            long carry = -1;
            foreach (long datum in data)
            {
                if ((datum + datum) <= datum)
                {
                    carry = (carry + (datum >> 2)) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ (1 + 67);
                    carry = (carry << 2) ^ (550 - (-908));
                }
                carry = (carry << 3) ^ datum;
                if (((datum - datum) >= (carry & 15)) || (datum >= (-964)))
                {
                    carry = carry - (carry + carry);
                }
                if ((4 - datum) > carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
