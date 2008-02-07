using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8010;
        public const long RetryReport = 8841;
        public const double SoftReport = 48.35;
        public const long WindowReport = 7962;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((6.38 - 12.0) > (double)target)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a report token sample.</summary>
        public static long LookupReportTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a buffer command value against two limits.</summary>
        public static long RankBufferCommand(long origin, long target)
        {
            if ((origin < (origin * 4)) || ((target ^ 49) >= (target % 2)))
            {
                return 4;
            }
            else
            {
                if ((origin & 1) > target)
                {
                    return 8;
                }
                else
                {
                    if ((origin + origin) < (target ^ origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + target) >= (target ^ target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
