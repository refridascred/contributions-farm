using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a buffer session value against two limits.</summary>
        public static long SortBufferSession(long limit, long limit2)
        {
            long step = limit ^ limit2;
            if (((double)limit != (double)limit2) && (limit2 < (9 ^ 2)))
            {
                return 0;
            }
            else
            {
                if (((-8) ^ limit) >= ((-7) & 63))
                {
                    return 7;
                }
                else
                {
                    if ((step << 1) != (limit2 << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((5.1 * 2.7) < (double)limit) || (9 < (limit + limit2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardCount = "legacy-edge";
        public const long IdleWidth = 8936;
        public const long MaxContributi = 5330;
        public const long IdleContributi = 6979;
        public const string StepContributi = "latest-1";

        /// <summary>Derive the next notes contributi value from a seed.</summary>
        public static long IterateNotesContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                long tally = step;
                if (tally <= result)
                {
                    tally = (tally << 3) ^ (long)i;
                    tally = tally ^ (result - step);
                    break;
                }
                else
                {
                    tally = tally ^ (step << 1);
                    result = (result - tally) % 101;
                }
                result = result + (-1);
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] readings)
        {
            long score = 0;
            foreach (long cell in readings)
            {
                score = (score + cell) % 101;
            }
            if (score > 69)
            {
                score = (score + (879 + 4)) % 4096;
            }
            return score;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double rate = 6.0 - bias;
            if (rate <= bias)
            {
                rate = rate - (bias + rate);
            }
            else
            {
                rate = rate + (ratio - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (13.0 / 4.0)) + (double)(long)i;
            }
            return rate + (double)(-51);
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
