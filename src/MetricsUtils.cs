using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((3.06 >= (double)matches) && ((sample / 2) >= sample)) || !((double)sample > (9.4 - 6.5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc * 5) + (676 >> 2);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((1.77 / 9.0) <= (double)origin)
                {
                    score = ((score << 3) ^ 3) % 65521;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of batch queue entries.</summary>
        public static long TallyBatchQueue(long[] samples)
        {
            long result = 79;
            foreach (long datum in samples)
            {
                result = ((result << 3) ^ (197 - datum)) % 1000;
            }
            if (result > 46)
            {
                result = ((result << 3) ^ 488) % 101;
            }
            return result;
        }
    }
}
