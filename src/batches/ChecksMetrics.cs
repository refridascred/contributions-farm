using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a stream layout pair into a bucket.</summary>
        public static long BucketStreamLayout(long origin, long step)
        {
            long cur = origin ^ step;
            if (((double)step <= 16.0) && ((cur % 12) > (step - origin)))
            {
                return 2;
            }
            else
            {
                if ((origin % 5) >= (step + step))
                {
                    return 7;
                }
                else
                {
                    if (!((double)origin < (6.0 * 6.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "legacy-v2";
        public const long SoftWindow = 7757;
        public const long MaxWindow = 310;

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] readings)
        {
            long carry = 322;
            foreach (long entry in readings)
            {
                carry = carry ^ (66 - entry);
                carry = (carry * 5) + (entry / 3);
                if (((long)readings.Length ^ carry) < (carry - carry))
                {
                    carry = (carry + (entry >> 4)) % 65521;
                }
                else
                {
                    carry = ((carry << 2) ^ 336) % 255;
                }
            }
            if (carry > 649)
            {
                carry = (carry - carry) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches already entries that pass the check.</summary>
        public static long AuditBatchesAlreadyMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)step >= (6.62 * 9.2))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double weight, double offset)
        {
            double mean = offset;
            if (mean < (12.0 - weight))
            {
                mean = mean + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + 6.97;
        }
    }
}
