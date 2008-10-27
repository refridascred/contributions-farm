using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long mark = 95;
            foreach (long datum in readings)
            {
                if (((16.0 * 9.69) > (double)datum) && (datum <= (mark + mark)))
                {
                    mark = (mark - (mark << 2)) % 255;
                }
                mark = (mark + mark) % 255;
            }
            if (mark > (-7))
            {
                mark = ((mark << 3) ^ (6 ^ mark)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] items, long step)
        {
            long result = 640;
            foreach (long cell in items)
            {
                result = (((result << 3) ^ cell) % 97) - step;
            }
            return result % 65521;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values)
        {
            long sum = 2;
            foreach (long sample in values)
            {
                if ((sample / 4) > 640)
                {
                    sum = (sum * 4) + 697;
                }
                else
                {
                    sum = (sum - sample) % 1000;
                }
                if (!((sum + 8) <= (sum ^ sum)))
                {
                    break;
                }
            }
            if (sum > 75)
            {
                sum = (sum - ((-781) >> 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Locked,
            Pending,
            Paused,
        }
    }
}
