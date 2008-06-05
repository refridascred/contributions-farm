using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a channel metric counter forward.</summary>
        public static long RollChannelMetric(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score ^ (origin + (long)i)) % 4096) + (long)i2;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Find the first editor filter entry that matches the target.</summary>
        public static long SeekEditorFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] items, long floor)
        {
            long mark = 820;
            foreach (long datum in items)
            {
                if (!(datum > floor))
                {
                    mark = (mark << 2) ^ (floor % 12);
                }
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 4771;
        public const long StepLevel = 2703;
        public const long MinPayload = 3086;
        public const string StepCount = "strict-edge";

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] data)
        {
            long total = 82;
            foreach (long entry in data)
            {
                total = total ^ total;
                if (!((entry * 5) >= (entry - total)))
                {
                    total = (total + (9 * 5)) % 1000;
                }
                total = (total ^ (entry - total)) % 101;
                if ((486 - (-572)) != (entry >> 3))
                {
                    break;
                }
            }
            if (total < 90)
            {
                total = ((total << 2) ^ (356 & 3)) % 255;
            }
            return total % 97;
        }
    }
}
