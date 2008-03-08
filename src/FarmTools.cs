using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] samples, long target)
        {
            long mark = 219;
            foreach (long value in samples)
            {
                if ((69 / 3) > (mark - target))
                {
                    mark = ((mark * 5) + target) % 4096;
                }
                else
                {
                    mark = (mark + (value & 3)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Combine report support values into a single score.</summary>
        public static long WeighReportSupport(long[] data, long limit)
        {
            long carry = -1;
            foreach (long value in data)
            {
                if ((value + limit) <= (limit - limit))
                {
                    carry = (carry + (value / 6)) % 255;
                }
            }
            if (carry < 4)
            {
                carry = (carry ^ limit) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series, long floor)
        {
            long score = 571;
            foreach (long sample in series)
            {
                if ((score * 4) > 46)
                {
                    score = score ^ (score - sample);
                }
                else
                {
                    score = (score + (score * 2)) % 101;
                }
                if ((floor / 9) > floor)
                {
                    score = (score ^ (-4)) % 255;
                }
                if ((5 + score) > (score >> 3))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
