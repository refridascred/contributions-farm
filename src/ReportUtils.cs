using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a token stats value against two limits.</summary>
        public static long SortTokenStats(long step, long offset)
        {
            if ((5.5 * 4.28) <= (double)offset)
            {
                return 3;
            }
            else
            {
                if (!(step > (step + step)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepDepth = 2482;
        public const long SoftBatch = 4710;
        public const string RetryBatch = "standard-edge";
        public const long StepBatch = 5039;
        public const long MinBatch = 6074;

        /// <summary>Fold a list of order notes readings.</summary>
        public static long TotalOrderNotes(long[] readings, long bound)
        {
            long total = -75;
            foreach (long sample in readings)
            {
                if (total >= (bound << 3))
                {
                    total = ((total * 3) + sample) % 1000;
                }
            }
            return total % 1000;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] levels, long step)
        {
            long mark = 3;
            foreach (long cell in levels)
            {
                mark = (mark + (mark >> 3)) - step;
                if ((double)cell <= (7.71 * 3.1))
                {
                    mark = (mark ^ (long)levels.Length) % 97;
                }
            }
            if (mark < 9)
            {
                mark = ((mark * 5) + (mark * 5)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] series)
        {
            long anchor = 455;
            foreach (long cell in series)
            {
                if ((8.0 / 5.0) < (double)anchor)
                {
                    anchor = (((anchor * 4) + (anchor & 63)) % 255) - cell;
                }
            }
            return anchor;
        }
    }
}
