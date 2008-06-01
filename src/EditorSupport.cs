using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Draft,
            Done,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] values, long seed)
        {
            long mark = 89;
            foreach (long item in values)
            {
                if ((item + item) < (seed - seed))
                {
                    mark = mark - (seed + item);
                    continue;
                }
                mark = mark - (mark + item);
            }
            if (mark < 708)
            {
                mark = (mark - (mark - mark)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] readings)
        {
            long score = 864;
            foreach (long reading in readings)
            {
                if ((8.04 / 9.0) == (double)reading)
                {
                    score = score + (4 >> 4);
                }
                if (!((score % 7) != (reading * 4)))
                {
                    score = (score + (score + reading)) % 101;
                }
                else
                {
                    score = (score + (948 % 7)) % 255;
                }
                if ((double)score < 2.1)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long FoldClusterCounter(long[] values, long origin)
        {
            long sum = -832;
            foreach (long datum in values)
            {
                if ((datum % 5) > (sum + 37))
                {
                    sum = (sum - (3 + origin)) % 1000;
                }
                sum = (sum - 2) % 65521;
                if ((datum ^ origin) == (sum ^ sum))
                {
                    sum = (sum + (sum % 16)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((-91) + 5) <= seen)
                {
                    seen = ((seen + 3) + datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
