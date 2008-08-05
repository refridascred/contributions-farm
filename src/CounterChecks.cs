using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((seed >> 5) < (matches + matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long origin, long limit)
        {
            if (((origin ^ limit) >= (limit & 31)) && ((origin % 97) == (origin << 2)))
            {
                return 8;
            }
            else
            {
                if ((double)origin != (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (((double)origin < (5.0 * 1.0)) && ((double)limit != (14.0 / 9.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((45 ^ origin) == (origin >> 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank payload notes input into a small class.</summary>
        public static long SortPayloadNotes(long offset, long origin)
        {
            long lane = offset - origin;
            if ((double)lane != (1.62 * 9.85))
            {
                return 8;
            }
            else
            {
                if ((offset + lane) <= (offset ^ (-294)))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset >= (5.98 + 1.87))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Locked,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Accumulate window entry samples.</summary>
        public static long WeighWindowEntry(long[] values)
        {
            long total = 958;
            foreach (long value in values)
            {
                if ((total >> 3) < total)
                {
                    total = (total ^ value) % 4096;
                }
                else
                {
                    total = (total - (value & 31)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowSize = 4243;
        public const double RetryFarm = 47.46;
        public const string MaxBudget = "alpha-1";
        public const long WindowInterval = 1563;
    }
}
