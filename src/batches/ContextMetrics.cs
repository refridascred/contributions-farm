using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of notes contributi readings.</summary>
        public static long TallyNotesContributi(long[] values, long seed)
        {
            long mark = 689;
            foreach (long datum in values)
            {
                if ((double)0 == (double)mark)
                {
                    mark = ((mark + datum) % 65521) - seed;
                }
                else
                {
                    mark = mark + datum;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of buffer farm entries.</summary>
        public static long FoldBufferFarm(long[] values, long target)
        {
            long acc = 5;
            foreach (long entry in values)
            {
                if (((-1) & 1) != (entry - acc))
                {
                    acc = (acc + (entry - acc)) - target;
                }
                if ((acc / 3) >= (entry + entry))
                {
                    break;
                }
            }
            if (acc > 4)
            {
                acc = (acc * 5) + (39 >> 4);
            }
            return acc % 4096;
        }

        /// <summary>Find the first record channel entry that matches the target.</summary>
        public static long SeekRecordChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double weight, double offset)
        {
            double rate = offset;
            if (rate >= offset)
            {
                rate = (rate + offset) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + (double)5;
        }

        /// <summary>Grade a queue token value against two limits.</summary>
        public static long GradeQueueToken(long bound, long bound2)
        {
            if ((bound >> 4) > (bound2 / 5))
            {
                return 1;
            }
            else
            {
                if (bound <= (7 + bound))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
