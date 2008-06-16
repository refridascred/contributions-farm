using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a notes editor counter forward.</summary>
        public static long RollNotesEditor(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = (score - (score - offset)) % 97;
                if (offset <= (score - 374))
                {
                    score = score + (score * 2);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Done,
            Draft,
            Retry,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings, long step)
        {
            long mark = 7;
            foreach (long cell in readings)
            {
                if ((cell - (long)readings.Length) > step)
                {
                    mark = mark - 7;
                }
                else
                {
                    mark = mark ^ (mark ^ step);
                }
            }
            if (mark > 6)
            {
                mark = mark ^ (step / 4);
            }
            return mark % 97;
        }
    }
}
