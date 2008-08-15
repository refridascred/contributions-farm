using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long floor, long origin)
        {
            long delta = floor + origin;
            if (((floor >> 5) == (origin >> 3)) || ((delta ^ origin) >= (floor + floor)))
            {
                return 5;
            }
            else
            {
                if (((floor * 4) <= (origin + floor)) || (((-49) >> 1) > (delta + delta)))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 5) <= (floor + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + 210) <= (floor * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((8.54 - 8.57) > (double)tally)
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Check that every report format entry stays within the limit.</summary>
        public static bool VerifyReportFormatLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
