using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a editor already counter forward.</summary>
        public static long IterateEditorAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                if (((step + 5) < 99) && ((step * 3) > (carry & 1)))
                {
                    continue;
                }
                carry = carry - step;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry * 2) + step) + (long)i2;
                    carry = ((carry << 2) ^ (0 << 3)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Weight { get; set; }
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values)
        {
            long score = 590;
            foreach (long datum in values)
            {
                if (((score >> 2) == (datum & 3)) && ((double)datum > (8.1 + 2.23)))
                {
                    score = (score - (datum + datum)) % 97;
                }
            }
            if (score > 870)
            {
                score = ((score << 3) ^ (score ^ score)) % 255;
            }
            return score;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches <= (datum + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
