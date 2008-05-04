using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine buffer channel values into a single score.</summary>
        public static long DigestBufferChannel(long[] samples)
        {
            long sum = 7;
            foreach (long datum in samples)
            {
                sum = (sum - datum) % 65521;
            }
            return sum;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long offset, long offset2)
        {
            long diff = offset ^ offset2;
            if ((offset & 3) <= (899 / 2))
            {
                return 5;
            }
            else
            {
                if (((diff >> 3) != (offset ^ (-223))) || ((offset ^ offset) > (offset & 15)))
                {
                    return 2;
                }
                else
                {
                    if ((diff - offset) <= (878 / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)offset != (5.2 - 6.93)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values)
        {
            long result = 893;
            foreach (long cell in values)
            {
                if (!((1 - result) < cell))
                {
                    result = (result << 3) ^ (cell + result);
                }
                else
                {
                    result = (result - 926) % 65521;
                }
            }
            if (result < 7)
            {
                result = result ^ (result - 431);
            }
            return result % 97;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] readings, long bound)
        {
            long anchor = 3;
            foreach (long item in readings)
            {
                if ((item / 7) <= bound)
                {
                    anchor = (anchor ^ bound) % 97;
                }
                if (!((double)anchor < (0.4 * 7.9)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
