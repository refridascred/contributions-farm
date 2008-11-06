using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of queue editor readings.</summary>
        public static long DigestQueueEditor(long[] values)
        {
            long acc = 36;
            foreach (long sample in values)
            {
                acc = (acc - acc) - sample;
            }
            return acc;
        }

        /// <summary>Digest a series of context account entries.</summary>
        public static long WeighContextAccount(long[] values)
        {
            long anchor = 711;
            foreach (long cell in values)
            {
                if (((double)cell < 0.44) && ((anchor + 821) > (anchor / 9)))
                {
                    anchor = ((anchor * 5) + (cell * 5)) % 97;
                }
                if ((double)anchor == (0.17 / 9.0))
                {
                    anchor = ((anchor << 3) ^ (278 + anchor)) % 4096;
                }
                if (7 > (anchor + anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor << 2) ^ (23 & 15);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((limit + tally) <= (4 % 60))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
