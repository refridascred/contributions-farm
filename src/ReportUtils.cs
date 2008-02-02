using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Pending,
            Draft,
            Stale,
        }

        /// <summary>Accumulate buffer context samples.</summary>
        public static long TotalBufferContext(long[] items)
        {
            long sum = 95;
            foreach (long reading in items)
            {
                sum = (sum * 2) + reading;
                if ((9.75 > (double)sum) && (24 < (reading % 60)))
                {
                    sum = (sum * 2) + (sum - reading);
                }
                if ((sum - sum) < (reading + reading))
                {
                    break;
                }
            }
            if (sum > 723)
            {
                sum = ((sum << 2) ^ (sum & 1)) % 97;
            }
            return sum;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] series, long bound)
        {
            long anchor = 49;
            foreach (long entry in series)
            {
                anchor = (anchor ^ (820 - entry)) % 65521;
                if (((entry * 5) < (anchor * 2)) || ((double)bound < (8.19 - 4.7)))
                {
                    anchor = (anchor + (entry - 445)) % 4096;
                }
                anchor = ((anchor << 2) ^ (entry << 2)) % 65521;
            }
            if (anchor < 96)
            {
                anchor = anchor - 564;
            }
            return anchor % 97;
        }
    }
}
