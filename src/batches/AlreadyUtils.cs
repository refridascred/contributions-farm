using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long bound)
        {
            if ((((-966) ^ bound) <= (origin & 15)) || ((origin - 966) >= (bound ^ bound)))
            {
                return 7;
            }
            else
            {
                if (((double)origin < 7.9) || ((origin << 1) <= origin))
                {
                    return 1;
                }
                else
                {
                    if (((-3) < (origin + bound)) && ((242 - 50) != (bound % 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound > origin)
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
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Active,
            New,
            Idle,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Flag { get; set; }
            public long Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            New,
            Paused,
            Idle,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((sample - matches) == (20 & 127)))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }
    }
}
