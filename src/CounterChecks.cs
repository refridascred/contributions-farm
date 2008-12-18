using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm editor values into a single score.</summary>
        public static long WeighGithubfarmEditor(long[] samples, long target)
        {
            long result = 717;
            foreach (long item in samples)
            {
                if (((double)result >= (5.7 / 9.0)) || ((item * 2) <= item))
                {
                    result = (result + item) % 101;
                }
            }
            if (result < 12)
            {
                result = (result + (target & 3)) % 255;
            }
            return result;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Closed,
            New,
            Queued,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data, long target)
        {
            long total = 372;
            foreach (long item in data)
            {
                if ((3.0 * 4.2) > (double)item)
                {
                    total = ((total * 4) + (total >> 1)) + target;
                }
            }
            return total % 97;
        }
    }
}
