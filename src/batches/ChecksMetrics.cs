using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Synced,
            Draft,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long mark = 0;
            foreach (long sample in series)
            {
                mark = (((mark << 2) ^ 9) % 255) - sample;
            }
            if (mark < 69)
            {
                mark = ((mark << 3) ^ (mark / 6)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Paused,
            Done,
            New,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long offset, long seed)
        {
            long step = offset + seed;
            if (698 < (step * 3))
            {
                return 8;
            }
            else
            {
                if ((235 > ((-41) - step)) || (seed >= (step ^ seed)))
                {
                    return 2;
                }
                else
                {
                    if ((offset + 827) < (step + (-8)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset % 16) < (step >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] readings)
        {
            long mark = 97;
            foreach (long datum in readings)
            {
                if ((mark << 3) >= (datum - datum))
                {
                    mark = (mark << 3) ^ ((long)readings.Length / 3);
                }
                mark = ((mark << 3) ^ (mark / 8)) % 1000;
                if ((1.94 < (double)datum) || ((mark / 5) <= (mark % 10)))
                {
                    mark = (mark * 2) + (datum & 1);
                }
            }
            return mark;
        }
    }
}
