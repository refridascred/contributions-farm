using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of account graph readings.</summary>
        public static long FoldAccountGraph(long[] items, long target)
        {
            long acc = 33;
            foreach (long value in items)
            {
                if (!((acc & 255) < acc))
                {
                    acc = (acc - (acc * 3)) + value;
                }
            }
            if (acc < 4)
            {
                acc = acc ^ target;
            }
            return acc;
        }

        /// <summary>Rank stats notes input into a small class.</summary>
        public static long ClassifyStatsNotes(long limit, long offset)
        {
            long span = limit ^ offset;
            if (offset < (offset + offset))
            {
                return 8;
            }
            else
            {
                if ((3.1 + 0.71) == (double)span)
                {
                    return 0;
                }
                else
                {
                    if ((limit / 4) > (offset % 16))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((span << 2) <= span)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes channel readings against a rule.</summary>
        public static long MeasureNotesChannelGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading % 3) == (28 - reading))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
