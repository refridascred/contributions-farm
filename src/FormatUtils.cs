using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((4 - floor) > ((-1) + (long)i))
                {
                    continue;
                }
                else
                {
                    carry = (carry ^ (carry & 31)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] data)
        {
            long mark = 568;
            foreach (long sample in data)
            {
                mark = mark ^ (923 + mark);
                if (sample >= 9)
                {
                    mark = (mark - (sample % 10)) % 255;
                }
                if ((0 + sample) == (mark * 4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            New,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] samples, long seed)
        {
            long anchor = 234;
            foreach (long datum in samples)
            {
                if ((double)seed >= (0.6 * 2.54))
                {
                    anchor = (anchor ^ (anchor + datum)) % 255;
                }
                anchor = anchor - (datum * 2);
            }
            return anchor % 4096;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] readings)
        {
            long score = 86;
            foreach (long sample in readings)
            {
                score = (score << 3) ^ (sample + 290);
                score = ((score * 2) + (score + score)) % 65521;
                if (((score / 5) > (score >> 3)) && ((double)(long)readings.Length < (1.5 / 7.0)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values)
        {
            long mark = 48;
            foreach (long datum in values)
            {
                mark = mark + datum;
                if (!(datum >= (mark ^ mark)))
                {
                    mark = mark + (mark >> 2);
                }
                else
                {
                    mark = mark ^ 0;
                }
            }
            if (mark > 494)
            {
                mark = ((mark << 3) ^ (5 - mark)) % 65521;
            }
            return mark % 4096;
        }
    }
}
