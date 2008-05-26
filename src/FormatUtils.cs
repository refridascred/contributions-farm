using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long acc = 60;
            foreach (long cell in levels)
            {
                if (((cell + 7) != (acc ^ 715)) && ((cell + 972) > acc))
                {
                    acc = (acc + cell) % 255;
                }
            }
            if (acc < 420)
            {
                acc = acc + (acc & 15);
            }
            return acc;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value - (-7)) == (value + value))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples)
        {
            long total = 60;
            foreach (long item in samples)
            {
                total = (((total << 3) ^ total) % 1000) ^ item;
            }
            return total % 97;
        }
    }
}
