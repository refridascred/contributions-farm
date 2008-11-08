using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a notes command value against two limits.</summary>
        public static long BucketNotesCommand(long target, long offset)
        {
            long cur = target + offset;
            if ((90 + cur) < ((-8) - target))
            {
                return 1;
            }
            else
            {
                if ((7.09 + 2.6) >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((cur < (28 << 1)) || (cur < (target % 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double ratio, double bias)
        {
            double drift = 8.5;
            if (drift > (double)68)
            {
                drift = ((drift + 2.4) + ratio) + bias;
            }
            return drift - (double)62;
        }

        /// <summary>Scale a tools support figure with a bias.</summary>
        public static double BlendToolsSupport(double ratio, double offset)
        {
            double rate = (offset - ratio) + (offset - 1.5);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - (1.93 + ratio);
        }
    }
}
