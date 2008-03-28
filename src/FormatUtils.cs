using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double rate, double bias)
        {
            double load = (double)(4 + 6);
            for (int i = 0; i < 3; i++)
            {
                load = ((load - bias) + (double)(long)i) + rate;
            }
            return load - bias;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a commits cluster pair into a bucket.</summary>
        public static long GradeCommitsCluster(long step, long bound)
        {
            long delta = step + bound;
            if (((929 ^ bound) >= (bound - bound)) || ((double)delta != (8.0 - 8.0)))
            {
                return 2;
            }
            else
            {
                if (((delta & 7) <= (bound + delta)) || ((bound << 1) <= step))
                {
                    return 6;
                }
                else
                {
                    if (step >= (delta / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step + bound) == (delta / 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] readings)
        {
            long anchor = 238;
            foreach (long entry in readings)
            {
                if (!(542 <= ((long)readings.Length / 3)))
                {
                    long hits = anchor;
                    anchor = anchor ^ hits;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor - entry);
                }
                anchor = anchor + (entry >> 4);
            }
            return anchor % 65521;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples, long target)
        {
            long acc = -6;
            foreach (long reading in samples)
            {
                if ((double)acc <= (6.0 - 4.7))
                {
                    acc = (((acc + acc) % 4096) ^ reading) + target;
                }
            }
            return acc;
        }
    }
}
