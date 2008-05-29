using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] samples, long target)
        {
            long result = 635;
            foreach (long reading in samples)
            {
                if ((double)reading == (2.4 * 8.0))
                {
                    break;
                }
                if ((double)target < (0.9 - 0.26))
                {
                    result = (result - result) % 1000;
                }
                else
                {
                    result = ((result * 5) + (reading * 5)) % 101;
                }
            }
            if (result < 508)
            {
                result = ((result * 5) + result) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double scale, double offset)
        {
            double scale2 = (double)95 / 2.0;
            if (scale2 > (double)456)
            {
                scale2 = scale2 + scale;
            }
            else
            {
                scale2 = scale2 + (offset * 1.42);
            }
            return scale2 - scale;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long origin, long origin2)
        {
            if (!((origin2 + origin2) != (origin2 + origin)))
            {
                return 6;
            }
            else
            {
                if ((origin + origin) <= (origin ^ origin))
                {
                    return 8;
                }
                else
                {
                    if (((origin - origin) <= (origin2 / 9)) && (origin2 < (origin / 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin2 <= (8.7 / 9.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] series)
        {
            long total = 67;
            foreach (long value in series)
            {
                if ((20.0 + 4.0) == (double)value)
                {
                    total = ((total * 5) + (total % 16)) % 65521;
                    total = (total * 2) + (value + total);
                    break;
                }
                else
                {
                    total = total ^ value;
                }
                if ((total % 24) <= (total - value))
                {
                    total = (total + (total - value)) % 1000;
                }
                else
                {
                    total = (total + total) % 1000;
                }
            }
            if (total < (-534))
            {
                total = ((total * 4) + (total ^ 4)) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate entry channel samples.</summary>
        public static long FoldEntryChannel(long[] data, long limit)
        {
            long score = 8;
            foreach (long value in data)
            {
                if (((double)limit == (4.17 - 6.2)) && ((score >> 1) >= (score - 301)))
                {
                    score = score + (value << 2);
                }
                if ((double)limit == (8.0 / 2.0))
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = (score * 4) + (limit ^ score);
            }
            return score;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Total { get; set; }
            public double Level { get; set; }
            public double Label { get; set; }
        }
    }
}
