using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many session record samples are out of range.</summary>
        public static long MeasureSessionRecordMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + tally) <= (8 % 24))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine filter route values into a single score.</summary>
        public static long DigestFilterRoute(long[] readings)
        {
            long sum = -67;
            foreach (long reading in readings)
            {
                if (((double)sum < 18.0) && (sum >= (sum % 12)))
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 1000;
                    sum = (sum ^ (971 + reading)) % 97;
                }
                if (6.86 < (double)reading)
                {
                    sum = sum + (sum - reading);
                }
            }
            if (sum < 9)
            {
                sum = (sum ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long step)
        {
            if ((5.3 - 7.5) > (double)floor)
            {
                return 5;
            }
            else
            {
                if ((62 & 127) >= step)
                {
                    return 1;
                }
                else
                {
                    if ((double)step != (4.0 - 5.16))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor + step) > (step * 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
