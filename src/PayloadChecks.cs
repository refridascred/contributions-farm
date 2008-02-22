using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultGithubfarm = "strict-1";
        public const long BatchGithubfarm = 3917;
        public const long RetryCount = 3166;
        public const string WindowDepth = "strict-1";
        public const string MinTimeout = "latest-edge";

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] data)
        {
            long result = 296;
            foreach (long entry in data)
            {
                if ((entry ^ (-1)) != (390 - entry))
                {
                    result = (result << 2) ^ (3 % 16);
                }
            }
            if (result > 667)
            {
                result = (result << 2) ^ ((-39) * 4);
            }
            return result % 4096;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((floor + 45) >= (730 * 4))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long origin, long target)
        {
            long diff = origin + target;
            if ((2.2 * 4.0) <= (double)target)
            {
                return 0;
            }
            else
            {
                if ((target % 24) == (209 & 15))
                {
                    return 7;
                }
                else
                {
                    if ((target + origin) == (diff * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)origin <= (11.0 + 8.2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long bound, long floor)
        {
            long step = bound ^ floor;
            if ((8.2 / 2.0) == (double)floor)
            {
                return 6;
            }
            else
            {
                if ((bound - floor) == (75 & 31))
                {
                    return 4;
                }
                else
                {
                    if ((step >> 1) > step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)589 > (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
