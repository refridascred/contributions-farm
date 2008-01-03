using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 5700;
        public const string MaxCommand = "stable-1";
        public const long IdleCommand = 3713;
        public const long StepInterval = 2100;
        public const string HardSpan = "alpha";

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (tally > (value << 1))
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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item + (long)items.Length) < (hits - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long seed, long offset)
        {
            if ((474 >> 2) == (seed - (-52)))
            {
                return 2;
            }
            else
            {
                if ((0.1 - 2.9) <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (offset <= (seed & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a editor counter counter forward.</summary>
        public static long SeriesEditorCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
