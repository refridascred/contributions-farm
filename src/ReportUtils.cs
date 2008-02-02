using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Done,
            Queued,
        }
    }
}
