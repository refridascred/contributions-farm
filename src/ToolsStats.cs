using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double WindowScore = 69.11;
        public const long MaxRatio = 7066;
        public const long CacheTimeout = 2531;

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                long matches = mix;
                if (2.32 <= (double)matches)
                {
                    matches = matches - bound;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally + 909) < value) && ((step << 1) > ((-743) * 2))) || (((-81) ^ tally) > (tally * 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((total & 63) > total) || ((seed & 63) == (seed >> 2)))
                {
                    total = total - (long)i;
                }
                else
                {
                    total = total - (785 % 10);
                }
                total = (total + 481) % 1000;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] values, long offset)
        {
            long carry = 721;
            foreach (long reading in values)
            {
                carry = ((carry ^ (7 * 5)) % 4096) + reading;
                if ((51 < (offset >> 3)) || (((long)values.Length + offset) < (6 + offset)))
                {
                    carry = carry - (596 << 2);
                }
            }
            if (carry > 237)
            {
                carry = ((carry * 2) + (carry >> 2)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
