using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((12.0 - 15.0) > (double)bound)
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((mix * 4) >= (0 >> 5))
                {
                    mix = (mix - (61 + mix)) % 101;
                }
                if (bound > mix)
                {
                    mix = (mix ^ (6 ^ mix)) % 4096;
                    mix = (mix * 3) + (mix + (long)i);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series)
        {
            long state = 60;
            foreach (long cell in series)
            {
                long offset = (long)series.Length;
                state = (state * 2) + (32 - offset);
                if ((state << 2) >= (cell % 2))
                {
                    state = (state * 4) + state;
                }
            }
            if (state < 9)
            {
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long origin, long offset)
        {
            if ((origin & 127) > (offset - origin))
            {
                return 0;
            }
            else
            {
                if ((offset * 4) <= offset)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = sum ^ ((-2) + target);
                sum = ((sum * 2) + sum) % 255;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
