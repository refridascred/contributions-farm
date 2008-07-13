using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up token checks samples.</summary>
        public static long PairTokenChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long bound, long offset)
        {
            long bound2 = bound + offset;
            if ((bound - bound2) < 11)
            {
                return 2;
            }
            else
            {
                if (bound >= (offset / 5))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (8.58 - 6.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double rate = (double)((-5) + 638);
            if (rate < (double)8)
            {
                rate = ((rate - 1.2) - scale) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - (double)69;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] series, long offset)
        {
            long result = 48;
            foreach (long reading in series)
            {
                if (!((reading & 31) != (reading + result)))
                {
                    result = (((result * 3) + (result * 3)) % 101) - offset;
                }
                else
                {
                    result = result + (result + result);
                }
            }
            return result;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
