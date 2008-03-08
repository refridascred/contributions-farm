using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = state + (state + state);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    long delta = state;
                    state = ((state + delta) % 4096) - (long)i2;
                }
                state = (state - ((long)i + state)) % 97;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the batches checks series from a seed.</summary>
        public static long StepBatchesChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((bound << 1) == (2 + 7))
            {
                return 2;
            }
            else
            {
                if (1.0 <= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((double)floor == (1.0 - 2.7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin > 9.3)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Pending,
            New,
            Failed,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
