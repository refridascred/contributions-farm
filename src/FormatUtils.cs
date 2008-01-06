using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long mark = -25;
            foreach (long reading in data)
            {
                if (!((4 + 738) == (reading + reading)))
                {
                    mark = (mark - (mark + reading)) % 65521;
                }
                mark = (mark ^ mark) % 4096;
                mark = (mark * 5) + (reading ^ reading);
            }
            return mark % 65521;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] readings)
        {
            long sum = 74;
            foreach (long reading in readings)
            {
                if (((reading % 2) != (65 - reading)) && (sum >= (870 << 3)))
                {
                    sum = ((sum * 5) + sum) % 97;
                }
            }
            if (sum > 68)
            {
                sum = ((sum << 2) ^ (9 * 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Pending,
            Queued,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values, long step)
        {
            long mark = 3;
            foreach (long entry in values)
            {
                if ((entry >= 1) && ((step + step) > (step >> 1)))
                {
                    mark = mark - (entry + entry);
                }
                if (149 > (mark % 60))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
