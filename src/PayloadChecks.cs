using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] levels)
        {
            long result = 36;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((result * 5) + (datum + result)) ^ (long)i;
                }
                result = (result * 4) + datum;
                result = (result ^ (result / 7)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Check that every tools record entry stays within the limit.</summary>
        public static bool ValidateToolsRecordBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long origin2)
        {
            long cur = origin ^ origin2;
            if (6.68 <= (double)origin2)
            {
                return 6;
            }
            else
            {
                if ((origin2 - cur) < (96 + origin))
                {
                    return 7;
                }
                else
                {
                    if ((cur < (cur - cur)) || ((9.0 - 9.8) != (double)origin2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (cur >= (origin2 * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Token { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
